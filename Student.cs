using System;
using System.Collections.Generic;
using System.Text;

namespace booking_library
{
    internal class Student
    {
       public static void func(List<string[]> rows)
        {
            string total = "";
            for(int i=0; i < rows.Count; i++)
            {
                for(int j=i; j < rows.Count; j++ )
                {
                    if (rows[i][2]=="student")
                    {
                        if ((rows[i][4]) - (rows[i][3]) > 14 )
                        {

                        }
                       

                    }
                    
                }
            }
        }
    }
}
