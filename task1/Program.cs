string[,] table =new string[2,5];
table[1, 2] = "наименование"; //обр. к нужному элементу
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
       Console.WriteLine($"-{table[rows, columns]}-"); 
    }
}