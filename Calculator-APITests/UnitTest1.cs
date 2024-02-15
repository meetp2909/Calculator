using MyApp.Namespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_APITests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
          var controller = new CalculatorController();

            var result = controller.Add(5, 3);

            Assert.AreEqual(8, result);
    }

        [TestMethod]
     public void Add_Returns_Zero_When_A_And_B_Are_Zero()
        {
            var controller = new CalculatorController();

            var result = controller.Add(0, 0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_Returns_A_When_B_Is_Zero()
        {
            var controller = new CalculatorController();

            var result = controller.Add(5, 0);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_Returns_B_When_A_Is_Zero()
        {

            var controller = new CalculatorController();

            var result = controller.Add(0, 10);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_Returns_Negative_Sum_When_A_And_B_Are_Negative()
        {

            var controller = new CalculatorController();

            var result = controller.Add(-5, -3);

            Assert.AreEqual(-8, result);
        }




     [TestMethod]
        public void Subtract_Returns_Correct_Result()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(5, 3);

            Assert.AreEqual(2, result);
        }


    [TestMethod]
        public void Subtract_Returns_Negative_Result_When_Subtracting_Larger_Number_From_Smaller_Number()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(3, 5);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Subtract_Returns_Zero_When_Subtracting_Number_From_Itself()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(10, 10);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Subtract_Returns_Negative_Result_When_Subtracting_Negative_Number_From_Positive_Number()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(5, -3);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_Returns_Positive_Result_When_Subtracting_Positive_Number_From_Negative_Number()
        {
            var controller = new CalculatorController();

            var result = controller.Subtract(-5, 3);

            Assert.AreEqual(-8, result);
        }



[TestMethod]
  public void Multiply_Returns_Correct_Result()
        {
            var controller = new CalculatorController();

            var result = controller.Multiply(5, 3);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
         public void Multiply_Returns_Zero_When_A_Is_Zero()
        {
            var controller = new CalculatorController();

            var result = controller.Multiply(0, 10);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_Returns_Zero_When_B_Is_Zero()
        {
            var controller = new CalculatorController();

            var result = controller.Multiply(5, 0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_Returns_Negative_Result_When_One_Number_Is_Negative()
        {
            var controller = new CalculatorController();

            var result = controller.Multiply(-5, 3);

            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void Multiply_Returns_Positive_Result_When_Both_Numbers_Are_Negative()
        {
        
            var controller = new CalculatorController();

            var result = controller.Multiply(-5, -3);

            Assert.AreEqual(15, result);
        }



         
[TestMethod]
public void Divide_Returns_Correct_Result()
        {
            
            var controller = new CalculatorController();

            
            var result = controller.Divide(10, 2) as OkObjectResult;

            
            Assert.IsNotNull(result);
            Assert.AreEqual(5, (decimal)result.Value);
        }
[TestMethod]
public void Divide_Returns_BadRequest_When_Dividing_By_Zero()
        {
            
            var controller = new CalculatorController();

            
            var result = controller.Divide(10, 0) as BadRequestObjectResult;

            
            Assert.IsNotNull(result);
            Assert.AreEqual("Cannot divide by zero", result.Value);
        }

        [TestMethod]
        public void Divide_Returns_Correct_Result_For_Negative_Dividend()
        {
            
            var controller = new CalculatorController();

            
            var result = controller.Divide(-10, 2) as OkObjectResult;

            
            Assert.IsNotNull(result);
            Assert.AreEqual(-5, (decimal)result.Value);
        }

        [TestMethod]
        public void Divide_Returns_Correct_Result_For_Negative_Divisor()
        {
            
            var controller = new CalculatorController();

            
            var result = controller.Divide(10, -2) as OkObjectResult;

            
            Assert.IsNotNull(result);
            Assert.AreEqual(-5, (decimal)result.Value);
        }

        [TestMethod]
        public void Divide_Returns_Correct_Result_For_Both_Negative_Numbers()
        {
            
            var controller = new CalculatorController();

            
            var result = controller.Divide(-10, -2) as OkObjectResult;

            
            Assert.IsNotNull(result);
            Assert.AreEqual(5, (decimal)result.Value);
        }

    }




    



    
