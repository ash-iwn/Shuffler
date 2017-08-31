using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Shuffler
{
    class Program
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public static extern int system(string command);

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Select File(s)");
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;
            fd.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.ShowDialog(); //Open File dialog box
            int len = fd.FileNames.Length;
            string[] nameArray = new string[len];

            for(int i = 0; i < len; i++) {
                Console.WriteLine(fd.FileNames[i]);
                nameArray[i] = fd.FileNames[i]; 
            }

            /*
             * 2 Methods 
             * 1) get number of plays in total from local file (based on name) 
             * 'n' songs look at last n/2 played songs.
             * assign them decreasing priority of 
             * 
             */
            system("pause");
        }
        
    }
}
