using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public Task task;
        private string text;
        private string word;
        private Cursor cursor;
        public List<string> dictionary { get; set; }

        public string Text { get => text; set { text = value; RaisePropertyChanged(); } }
        public string Word { get => word; set { word = value; RaisePropertyChanged(); } }
        public Task CreateTask() => new Task(() => { Action(); });


        public Stopwatch stop { get; set; } = new Stopwatch();
        private Thread thread { get; set; }


        private int Button0 { get; set; } = 0;
        private int Button1 { get; set; } = 0;
        private int Button2 { get; set; } = 0;
        private int Button3 { get; set; } = 0;
        private int Button4 { get; set; } = 0;
        private int Button5 { get; set; } = 0;
        private int Button6 { get; set; } = 0;
        private int Button7 { get; set; } = 0;
        private int Button8 { get; set; } = 0;


        public Cursor Cursor
        {
            get => cursor;
            set { cursor = value; RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            dictionary = new List<string>() { "salam" };
            task = CreateTask();
            task.Start();
        }


        public RelayCommand Command
        {
            get => new RelayCommand(() =>
            {
                if (Text.Contains(" "))
                {
                    var result = Text.Split(' ').Last();
                    for (int i = result.Length; i < Word.Length; i++) { Text += Word[i]; }
                    Word = "";
                }
                else
                {
                    var result = Text;
                    for (int i = result.Length; i < Word.Length; i++) { Text += Word[i]; }
                    Word = "";
                }
            });
        }

        public RelayCommand AddCommand
        {
            get => new RelayCommand(() =>
            {
                if (Text.Contains(" "))
                {
                    var result = Text.Split(' ').Last();
                    dictionary.Add(result);
                }
                else
                {
                    var result = Text;
                    dictionary.Add(result);
                }
            });
        }




        public RelayCommand Backspace
        {
            get => new RelayCommand(() =>
            {
                int other = Text.Length - 1;
                Text = Text.Remove(other);
            });
        }

        public RelayCommand OneButtonCommand
        {
            get => new RelayCommand(
            () => { Text += "1"; });
        }


        public RelayCommand TwoButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button1 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button1 = 0;
                }
                if (Button1 == 0)
                {
                    Text += "a";
                    Button1++;
                    stop.Start();
                    return;
                }
                else if (Button1 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button1++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'b';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button1 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button1++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'c';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button1 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button1++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '2';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else
                    {

                        stop.Reset();
                    }
                }
                else if (Button1 == 4) { Button1 = 0; }

            });
        }


        public RelayCommand ThreeButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button2 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button2 = 0;
                }
                if (Button2 == 0)
                {
                    Text += "d";
                    Button2++;
                    stop.Start();
                    return;
                }
                else if (Button2 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button2++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'e';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button2 == 2)
                {

                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button2++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'f';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button2 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button2++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '3';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button2 == 4) { Button2 = 0; }
            });
        }

        public RelayCommand FourButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button3 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button3 = 0;
                }
                if (Button3 == 0)
                {
                    Text += "g";
                    Button3++;
                    stop.Start();
                    return;
                }
                else if (Button3 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button3++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'h';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button3 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button3++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'i';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button3 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button3++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '4';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button3 == 4) { Button3 = 0; }
            });
        }

        public RelayCommand FiveButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button4 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button4 = 0;
                }
                if (Button4 == 0)
                {
                    Text += "j";
                    Button4++;
                    stop.Start();
                    return;
                }
                else if (Button4 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button4++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'k';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button4 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button4++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'l';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button4 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button4++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '5';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button4 == 4) { Button4 = 0; }
            });
        }

        public RelayCommand SixButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button5 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button5 = 0;
                }
                if (Button5 == 0)
                {
                    Text += "m";
                    Button5++;
                    stop.Start();
                    return;
                }
                else if (Button5 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button5++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'n';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button5 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button5++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'o';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button5 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button5++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '6';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button5 == 4) { Button5 = 0; }
            });
        }

        public RelayCommand SevenButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button6 == 5)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button6 = 0;
                }
                if (Button6 == 0)
                {
                    Text += "p";
                    Button6++;
                    stop.Start();
                    return;
                }
                else if (Button6 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button6++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'q';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button6 == 2)
                {

                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button6++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'r';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button6 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button6++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 's';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button6 == 4)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button6++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '7';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button6 == 5) { Button6 = 0; }
            });
        }

        public RelayCommand EightButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button7 == 4)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button7 = 0;
                }
                if (Button7 == 0)
                {
                    Text += "t";
                    Button7++;
                    stop.Start();
                    return;
                }
                else if (Button7 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button7++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'u';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button7 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button7++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'v';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button7 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button7++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '8';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button7 == 4) { Button7 = 0; }
            });
        }

        public RelayCommand NineButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button8 == 5)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button8 = 0;
                }
                if (Button8 == 0)
                {
                    Text += "w";
                    Button8++;
                    stop.Start();
                    return;
                }
                else if (Button8 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button8++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'x';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button8 == 2)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button8++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'y';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button8 == 3)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button8++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += 'z';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button8 == 4)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button8++;
                        int ind = Text.Length - 1;
                        Text = Text.Remove(ind);
                        Text += '9';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button8 == 5) { Button8 = 0; }
            });
        }


        public RelayCommand ZeroButtonCommand
        {
            get => new RelayCommand(
            () =>
            {
                stop.Stop();
                if (Button0 == 2)
                {
                    int other = Text.Length - 1;
                    Text = Text.Remove(other);
                    Button0 = 0;
                }
                if (Button0 == 0)
                {
                    Text += " ";
                    Button0++;
                    stop.Start();
                    return;
                }
                else if (Button0 == 1)
                {
                    if (stop.Elapsed.Seconds <= 1)
                    {
                        Button0++;
                        int other = Text.Length - 1;
                        Text = Text.Remove(other);
                        Text += '0';
                        stop.Reset();
                        stop.Start();
                        return;
                    }
                    else { stop.Reset(); }
                }
                else if (Button0 == 2) { Button0 = 0; }
            });
        }

        public void Action()
        {
            while (true)
            {
                if (stop.Elapsed.Seconds > 1)
                {
                    stop.Stop();
                    stop.Reset();
                    Cursor = Cursors.Help;

                    if (Text.Contains(" "))
                    {
                        var result = Text.Split(' ').Last();
                        foreach (var word in dictionary) { if (word.StartsWith(result) && result != "") { Word = word; } }
                    }
                    else
                    {
                        var result = Text;
                        foreach (var word in dictionary) { if (word.StartsWith(result) && result != "") { Word = word; } }
                    }

                    Button0 = 0;
                    Button1 = 0;
                    Button2 = 0;
                    Button3 = 0;
                    Button4 = 0;
                    Button5 = 0;
                    Button6 = 0;
                    Button7 = 0;
                    Button8 = 0;
                }
            }
        }

    }
}
