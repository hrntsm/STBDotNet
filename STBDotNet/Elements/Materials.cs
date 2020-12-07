namespace STBDotNet.Elements
{
    public enum StrengthConcrete
    {
        Fc18,
        Fc21,
        Fc24,
        Fc27,
        Fc30,
        Fc33,
        Fc36,
        Fc40,
        Fc42,
        Fc45,
        Fc50,
        Fc55,
        Fc60,
        Fc70,
        Fc80,
        Fc90,
        Fc100,
        Other
    }

    public enum StrengthSteel
    {
        S80,  // LY100
        S205, // LY225
        S235, // SN400‘¼
        S295, // BCR295‘¼
        S325, // SN490‘¼
        S355,
        S385,
        S440,
        Other
    }

    public enum StrengthBar
    {
        S235,
        S295,
        S345,
        S685,
        S785,
        S1275,
        Other
    }
}