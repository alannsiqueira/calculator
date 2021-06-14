using FluentAssertions;
using TechTalk.SpecFlow;

namespace Test.Steps
{
    [Binding]
    public class AdditionStepDefinition
    {
        private double _operand1;
        private double _operand2;
        private double _actualResult;


        [Given(@"o operando (.*) e o operando (.*)")]
        public void SetOperands(double operand1, double operand2)
        {
            _operand1 = operand1;
            _operand2 = operand2;
        }

        [Given(@"realizo a operação de adição com esses operandos")]
        public void SetOperator()
        {
            _actualResult = _operand1 + _operand2;

        }

        [Then(@"espero ter como resultado o valor de (.*)")]
        public void GetResult(double expectedResult)
        {
            _actualResult.Should().Be(expectedResult, "Minha mensagem de erro personalizada");
        }
    }


}
