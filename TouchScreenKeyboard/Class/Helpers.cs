using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TouchScreenKeyboard.Class
{
    public static class Helpers
    {
        public static void FormPosition(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized || form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }

            form.Width = Screen.PrimaryScreen.WorkingArea.Width;
            form.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - form.Width), (Screen.PrimaryScreen.WorkingArea.Height - form.Height));
        }

        public static void ButtonFontResize(Form form)
        {
            int divide = 12;

            if (form.WindowState != FormWindowState.Minimized)
            {
                var buttons = GetAll(form, typeof(Button)).ToList();

                for (int i = 0; i < buttons.Count; i++)
                {
                    int buttonSize = buttons[i].Height + buttons[i].Width;
                    buttons[i].Font = new Font("Microsoft Sans Serif", buttonSize / divide);
                }
            }
        }

        public static void SpecialCharactersButtonTextChange(Form form, bool shift, string AccessibleDescription, char split)
        {
            var buttons = GetDescriptionAll(form, typeof(Button), AccessibleDescription).ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                string[] splitString = buttons[i].Tag.ToString().Split(split);

                if (shift)
                {
                    buttons[i].Text = splitString[0];
                }
                else
                {
                    buttons[i].Text = splitString[1];
                }
            }
        }

        public static void CharacterButtonTextToUpper(Form form, string AccessibleDescription)
        {
            var buttons = GetDescriptionAll(form, typeof(Button), AccessibleDescription).ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                string upperText = buttons[i].Text;
                buttons[i].Text = upperText.ToUpper();
            }
        }

        public static void CharacterButtonTextToLower(Form form, string AccessibleDescription)
        {
            var buttons = GetDescriptionAll(form, typeof(Button), AccessibleDescription).ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                string upperText = buttons[i].Text;
                buttons[i].Text = upperText.ToLower();
            }
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public static IEnumerable<Control> GetDescriptionAll(Control control, Type type, string description)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetDescriptionAll(ctrl, type, description)).Concat(controls).Where(c => c.GetType() == type && c.AccessibleDescription == description);
        }

        public static IEnumerable<Control> GetNameAll(Control control, Type type, string name)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetNameAll(ctrl, type, name)).Concat(controls).Where(c => c.GetType() == type && c.AccessibleDescription == name);
        }
    }
}
