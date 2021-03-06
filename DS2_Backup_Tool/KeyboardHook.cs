﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// ReSharper disable once CheckNamespace
public sealed class KeyboardHook : IDisposable
{
    private int currentId;
    // Registers a hot key with Windows.
    private readonly Window window = new Window();

    public KeyboardHook()
    {
        // register the event of the inner native window.
        window.KeyPressed += delegate(object sender, KeyPressedEventArgs args)
        {
            if (KeyPressed != null)
            {
                KeyPressed(this, args);
            }
        };
    }

    public void Dispose()
    {
        // unregister all the registered hot keys.
        for (var i = currentId; i > 0; i--)
        {
            UnregisterHotKey(window.Handle, i);
        }

        // dispose the inner native window.
        window.Dispose();
    }

    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    // Unregisters the hot key with Windows.
    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    /// <summary>
    ///     Registers a hot key in the system.
    /// </summary>
    /// <param name="modifier">The modifiers that are associated with the hot key.</param>
    /// <param name="key">The key itself that is associated with the hot key.</param>
    public void RegisterHotKey( Keys key, ModifierKey modifier)
    {
        // increment the counter.
        currentId = currentId + 1;

        // register the hot key.
        if (!RegisterHotKey(window.Handle, currentId, (uint) modifier, (uint) key))
            throw new InvalidOperationException("Couldn’t register the hot key.");
    }


    

    /// <summary>
    ///     A hot key has been pressed.
    /// </summary>
    public event EventHandler<KeyPressedEventArgs> KeyPressed;

    /// <summary>
    ///     Represents the window that is used internally to get the messages.
    /// </summary>
    private sealed class Window : NativeWindow, IDisposable
    {
        private const int WM_HOTKEY = 0x0312;

        public Window()
        {
            // create the handle for the window.
            CreateHandle(new CreateParams());
        }

        public void Dispose()
        {
            DestroyHandle();
        }

        /// <summary>
        ///     Overridden to get the notifications.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // check if we got a hot key pressed.
            if (m.Msg == WM_HOTKEY)
            {
                // get the keys.
                var key = (Keys) (((int) m.LParam >> 16) & 0xFFFF);
                var modifier = (ModifierKey) ((int) m.LParam & 0xFFFF);

                // invoke the event to notify the parent.
                if (KeyPressed != null)
                    KeyPressed(this, new KeyPressedEventArgs(modifier, key));
            }
        }

        public event EventHandler<KeyPressedEventArgs> KeyPressed;
    }
}

/// <summary>
///     Event Args for the event that is fired after the hot key has been pressed.
/// </summary>
public class KeyPressedEventArgs : EventArgs
{
    private readonly Keys key;
    private readonly ModifierKey modifier;

    internal KeyPressedEventArgs(ModifierKey modifier, Keys key)
    {
        this.modifier = modifier;
        this.key = key;
    }

    public ModifierKey Modifier
    {
        get { return modifier; }
    }

    public Keys Key
    {
        get { return key; }
    }
}

/// <summary>
///     The enumeration of possible modifiers.
/// </summary>
[Flags]
public enum ModifierKey : uint
{
    None = 0,
    Alt = 1,
    Control = 2,
    Shift = 4,
    Win = 8
}