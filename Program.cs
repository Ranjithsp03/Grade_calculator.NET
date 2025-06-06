double Englishcredit = 3;
double Algebracredit = 3;
double Biologycredit = 3;
double Cscredit = 3;
double Psychologycredit = 3;
Console.WriteLine("Enter the StudentName:");
string StudentName = Convert.ToString(Console.ReadLine());
int[] Sub = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the Subject" + (i+1), "Grade");
    Sub[i] = int.Parse(Console.ReadLine());
}
double totalcredit = Englishcredit + Algebracredit + Biologycredit + Cscredit + Psychologycredit;
double cgpa = ((Sub[0] * Englishcredit) + (Sub[1] * Algebracredit) + (Sub[2] * Biologycredit) + (Sub[3] * Cscredit) + (Sub[4] * Psychologycredit)) / totalcredit;

Console.WriteLine("The total cgpa is:" +cgpa);

