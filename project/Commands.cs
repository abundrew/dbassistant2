using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dbassistant
{
    public class Commands
    {
        public static RoutedUICommand Open { get; private set; }
        public static RoutedUICommand Exit { get; private set; }
        public static RoutedUICommand Tables { get; private set; }
        public static RoutedUICommand Routines { get; private set; }
        public static RoutedUICommand Close { get; private set; }
        public static RoutedUICommand CloseAll { get; private set; }
        public static RoutedUICommand About { get; private set; }

        static Commands()
        {
            Open = new RoutedUICommand("_Open", "Open", typeof(Commands), new InputGestureCollection(new KeyGesture[] {
                new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O")
            }));
            Exit = new RoutedUICommand("E_xit", "Exit", typeof(Commands));
            Tables = new RoutedUICommand("_Tables", "Tables", typeof(Commands), new InputGestureCollection(new KeyGesture[] {
                new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T")
            }));
            Routines = new RoutedUICommand("_Routines", "Routines", typeof(Commands), new InputGestureCollection(new KeyGesture[] {
                new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R")
            }));
            Close = new RoutedUICommand("_Close", "Close", typeof(Commands));
            CloseAll = new RoutedUICommand("Close _All", "Close", typeof(Commands));
            About = new RoutedUICommand("_About", "About", typeof(Commands));
        }
    }
}
