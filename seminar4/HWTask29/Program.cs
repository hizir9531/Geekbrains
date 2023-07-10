int length = 8;
int[] N = new int[length];
Console.Write("{");
for (int i = 0; i < length; i++)
{
    N[i] = new Random().Next(-200, 200);
    Console.Write(N[i] + ";");
}
Console.Write("}");