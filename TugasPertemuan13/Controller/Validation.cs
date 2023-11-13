using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TugasPertemuan13.Controller
{
    internal class Validation
    {
        //Validasi Username
        public bool valUsername(string uname)
        {
            for (int a = 0; a < uname.Length; a++)
            {
                if ((uname[0] == ' ' || uname[uname.Length - 1] == ' ' || uname[a] == '_' ||
                    uname[a] == '&' || uname[0] == '-' || uname[uname.Length - 1] == '-' ||
                    uname[a] == '/' || uname[a] == '\\' || uname[a] == '+' || uname[a] == '-' || uname[a] == ',' || uname[a] == '\'' || uname[a] == '<' ||
                    uname[a] == '>' ))
                {
                    MessageBox.Show("Input Username failed", "add admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        //Validasi Password
        public bool valPassword(string pw)
        {
            for (int a = 0; a < pw.Length; a++)
            {
                if ((pw[0] == ' ' || pw[pw.Length - 1] == ' ' ||
                    pw[pw.Length - 1] == '-' || pw[a] == '/' || pw[a] == '\\' || pw[a] == '?' ||
                    pw[a] == '!' || pw[a] == '@' || pw[a] == '#' || pw[a] == '$' || pw[a] == '%' ||
                    pw[a] == '^' || pw[a] == '&' || pw[a] == '*' || pw[a] == '(' || pw[a] == ')' ||
                    pw[a] == '`' || pw[a] == '~' || pw[a] == '-' || pw[a] == '+' || pw[a] == '=' ||
                    pw[a] == '[' || pw[a] == ']' || pw[a] == '{' || pw[a] == '}' || pw[a] == ';' ||
                    pw[a] == '\''|| pw[a] == ':' || pw[a] == '\"'|| pw[a] == ','|| pw[a] == '.' ||
                    pw[a] == '/' || pw[a] == '>' || pw[a] == '<' || pw[a] == '|'))
                {
                    MessageBox.Show("Input Password failed", "add Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

      

    }
}

