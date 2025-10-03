string frasecorreta, frasedislalia;
Console.WriteLine("escreva um texto: ");
frasecorreta = Console.ReadLine();
frasedislalia = frasecorreta.Replace ("r", "l");
Console.WriteLine(frasedislalia);