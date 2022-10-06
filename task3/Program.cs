Console.Clear();
Console.Write("digit (day of the week)-> ");
int day = Convert.ToInt32(Console.ReadLine());
void x (int day) {
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("holiday");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("onli 7 days");
  }
  else Console.WriteLine("not holiday");
}
x(day);
Console.WriteLine(day);