using System.Globalization;

namespace Question_4{

    public class Program{
        static void Main(){
            double sp, rj,mg,es, outros, total;
            sp = 67836.43;
            rj = 36678.66;
            mg = 29229.88;
            es = 27165.48;
            outros = 19849.53;

            total = sp+rj+mg+es+outros;
            System.Console.WriteLine("Total adquired:");
            System.Console.WriteLine(total+"\n");
            System.Console.WriteLine("Total selling percentage per state:");
            System.Console.WriteLine("SP:");
            System.Console.WriteLine(percentState(sp,total).ToString("n2")+"%");

            System.Console.WriteLine("RJ:");
            System.Console.WriteLine(percentState(rj,total).ToString("n2")+"%");

            System.Console.WriteLine("MG:");
            System.Console.WriteLine(percentState(mg,total).ToString("n2")+"%");

            System.Console.WriteLine("ES:");
            System.Console.WriteLine(percentState(es,total).ToString("n2")+"%");

            System.Console.WriteLine("Other states:");
            System.Console.WriteLine(percentState(outros,total).ToString("n2")+"%");
        }
        static double percentState(double state, double total){
            return (state/total)*100;
        }
    }
}
