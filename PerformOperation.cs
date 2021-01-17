using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace PerformMathematicalOperations
{
    public class PerformOperation : CodeActivity

    {

        public enum modeOfOperation
        {

            Addition,
            Subtraction,
            Multiplication,
            Division

        }

        // Define Input & Output Parameters

        [Category("Input")]
        [RequiredArgument]
        public InArgument<Double> firstNumber { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<Double> secondNumber { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public modeOfOperation operation { get; set; }

        [Category("Output")]
        [RequiredArgument]
        public OutArgument<Double> result { get; set; }


        protected override void Execute(CodeActivityContext context)
        {

            Double firstInput = firstNumber.Get(context);
            Double secondInput =secondNumber.Get(context);
            Double outputNumber = 0.0;

            if (operation == modeOfOperation.Addition)
            {

                outputNumber = firstInput + secondInput;

            }
            else if (operation == modeOfOperation.Subtraction)
            {

                outputNumber = firstInput - secondInput;

            }
            else if (operation == modeOfOperation.Multiplication)
            {

                outputNumber = firstInput * secondInput;

            }
            else if (operation == modeOfOperation.Division)
            {

                outputNumber = firstInput / secondInput;

            }

            result.Set(context, result);


            // throw new NotImplementedException();
        }


    }
}
