bool IsNumber (int[] mas, int num)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (num == mas[i])
            return true;
    }
    return false;
}
