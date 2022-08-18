using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager;

namespace WpfApp1
{
    internal class WPFUserInterface : IUserInterface
    {
        private MainWindow _mw;
        public WPFUserInterface(MainWindow mainWindow)
        {
                _mw=mainWindow;
        }

        public void Write(string str)
        {
            _mw.LeftTb.Text = _mw.LeftTb.Text + "  " + str;
        }

        public void WriteLine(string str)
        {
            _mw.LeftTb.Text = _mw.LeftTb.Text + str + "\n";
        }

        public void WritePrompt(string? Prompt, bool PromptNewLine)
        {
            //if(Prompt != null && Prompt.Length > 0)
            if (Prompt is { Length: > 0 })
                if (PromptNewLine)
                    WriteLine(Prompt);
                else
                    Write(Prompt);
        }

        public void ClearLeftTb()
        {
            _mw.LeftTb.Text = "";
        }
        public void ClearCommandPrompt()
        {
            _mw.Tbox1.Text = "";
        }

        public string ReadLine(string? Prompt, bool PromptNewLine = true)
        {
            WritePrompt(Prompt, PromptNewLine);

            return _mw.Tbox1.Text;
        }

        public int ReadInt(string? Prompt, bool PromptNewLine = true)
        {
            bool success;
            int value;
            do
            {
                WritePrompt(Prompt, PromptNewLine);

                var input = _mw.Tbox1.Text;
                success = int.TryParse(input, out value);
                if (!success)
                    WriteLine("Строка имела неверный формат");
            }
            while (!success);

            return value;
        }

        public double ReadDouble(string? Prompt, bool PromptNewLine = true)
        {
            bool success;
            double value;
            do
            {
                WritePrompt(Prompt, PromptNewLine);

                var input = _mw.Tbox1.Text;
                success = double.TryParse(input, out value);
                if (!success)
                    WriteLine("Строка имела неверный формат");
            }
            while (!success);

            return value;
        }

        public void ShowTextInfo(string str)
        {
            _mw.UpperTb.Text = str;
        }
    }
}
