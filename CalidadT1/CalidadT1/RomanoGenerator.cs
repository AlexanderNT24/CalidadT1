namespace CalidadT1;

public class RomanoGenerator
{
    private Dictionary<int, string> romanos = new Dictionary<int, string>()
    {
        {1,"I"},
        { 4,"IV"}, 
        {5,"V"}, 
        {9,"IX"}, 
        {10,"X"}, 
        {40,"XL"}, 
        {50,"L"}, 
        {90,"XC"}, 
        {100,"C"}, 
        {400,"CD"}, 
        {500,"D"}, 
        {900,"CM"}, 
        {1000,"M"},
    };
    // si se envia un numero menor a 1 debe enviar error/ validar hasta el 1000
    public string GetRomano(int number)
    {
        var romano = "";
        if (number >= 1)
        {
            foreach (var item in romanos.Reverse())
            {
                if (number <= 0) break;
                while (number >= item.Key)
                {
                    romano += item.Value;
                    number -= item.Key;
                }
            }
            return romano;
        }
        else
        {
            return "error";
        }

    }
}