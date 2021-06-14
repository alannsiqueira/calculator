using System.ComponentModel;

namespace Domain.Enumerators
{
    public enum EOperator
    {
        [Description("+")]
        Addition,

        [Description("-")]
        Subtraction,

        [Description("*")]
        Multiplication,

        [Description("/")]
        Division
    }
}