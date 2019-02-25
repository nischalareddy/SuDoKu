using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuDoKu
{
    static class Globals
    {

        [DllImport("kernel32")]
        static public extern bool AllocConsole();

        static public string path = @"C:\repos\KalBootCamp\SuDoKu\SuDoKuSolvedPuzzle\SolvedPuzzleData.txt";
        static public string upath = @"C:\repos\KalBootCamp\SuDoKu\SuDoKuSolvedPuzzle\UnsolvedPuzzleData.txt";
    }
}
