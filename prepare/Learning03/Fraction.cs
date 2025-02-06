public class Fraction{
    private int _top;
    private int _bottom;


    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNum){
        _top = wholeNum;
        _bottom = 1;
    }

    public Fraction(int topNum,int botNum){
        _top = topNum;
        _bottom = botNum;
    }

//Method to get fraction string
    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }

//Method to get decimal value
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}