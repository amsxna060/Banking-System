namespace Extensions;

static class ExtensionMethods
{
    public static string MaskStrings(this String accountNumber)
    {
        char[] hiddenAccNo = accountNumber.ToCharArray();
        for (int i = 2; i < accountNumber.Length - 4; i++)
        {
            hiddenAccNo[i] = 'x';
        }
        return new String(hiddenAccNo);
    }
}