using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public class Discriminant
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public int answer;

        private void discriminant(int a, int b, int c)
        {
            double square_side = Convert.ToInt64(Math.Pow(b, 2) - 4 * -a * -c);


            if (square_side > 0)
            {
                answer = 2;
                
            }
            else if (square_side == 0)
            {

                answer = 1;
            }
            else
            {
                answer = 0;

            }
        }
    }
}