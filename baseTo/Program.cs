namespace baseTo;
class Program
{
    static void Main(string[] args)
    {
       int n = Convert.ToInt32(Console.ReadLine().Trim());
        string deci="";
        int remainder;
        int lastRemainder=0;
        int count=0;
        int biggest=1;
        while(n > 0){

        remainder = n%2;
        if(lastRemainder==remainder){
            count++;
            if(count>biggest){
                biggest=count;
            }
        }else{


            count=1;
        }
       lastRemainder=remainder;
        n = n/2;

        deci = Convert.ToString(remainder)+deci;}
        Console.WriteLine(biggest);


    }
}
