/***************************
 * Assignment 1 - MSTest - Unit Test
 * Title: Unit Tests for Various Methods in Aclass
 * Course: CSCN72010-23F-Sec3 
 * Professor: Prashathan Cheluvasai Ranga
 * Date: October 06, 2023
 * By: Hangsihak Sin
 ***************************/

using System.Formats.Asn1;

namespace Assignment1.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_1_2_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 1;
            int num2 = 2;
            bool expected = true;

            // Act
            bool actual = aclass.Check(num1, num2);     // Returns True as num1 is less than equal to num2 
            
            // Assert
            Assert.IsTrue(actual == expected);          // Verify that the expected and actual condition are both True.
                                                        // Assert.IsTrue() is used to validate that a given condition evaluates to True.
                                                        // In this case, expected is True, and actual also returns True when compared, making the condition True which meets IsTrue() condition.
                                                        // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Check_5_2_ReturnFalse()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 5;
            int num2 = 2;
            bool expected = true;

            // Act
            bool actual = aclass.Check(num1, num2);     // Returns False as num1 is not less than or equal to num2

            // Assert
            Assert.IsTrue(actual == expected);          // Verify that the expected and actual condition are both True.
                                                        // Assert.IsTrue() is used to validate that a given condition evaluates to True.
                                                        // In this case, expected is True, but actual returns False when compared, making the condition False which does not meet IsTrue() condition.
                                                        // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Max_98F_1F_28F_Return98F()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            float num1 = 98.65538F;
            float num2 = 1.98765F;
            float num3 = 28.13435F;
            float expected = 98.65538F;

            // Act
            float actual = aclass.Max(num1, num2, num3);    // Return 98.65538 as it is the largest between the three numbers

            // Assert
            Assert.AreEqual(expected, actual);              // Verify that the expected and actual results are Equal.
                                                            // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                            // In this case, expected is 98.65538 and actual also returns 98.65538 when compared, making the condition False which meets AreEqual() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Max_3F_912F_12F_Return912F()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            float num1 = 3.54124F;
            float num2 = 912.32435F;
            float num3 = 12.23578F;
            float expected = 12.23578F;

            // Act
            float actual = aclass.Max(num1, num2, num3);    // Returns 912.32435 as it is the largest between the three numbers

            // Assert
            Assert.AreEqual(expected, actual);              // Verify that expected and actual results are Equal
                                                            // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                            // In this case, expected is 12.23578 but actual returns 912.32435 when compared, making the condition False which does not meet AreEqual() condition.
                                                            // Thus, the assertion should Fail.

        }

        [TestMethod]
        public void Max_14F_5F_9F_Return14F()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            float num1 = 14.12894F;
            float num2 = 5.23520F;
            float num3 = 9.12475F;
            float expected = 1.41289F;

            // Act
            float actual = aclass.Max(num1, num2, num3);        // Returns 14.12894 as it is the largest between the three numbers

            // Assert
            Assert.AreNotEqual(expected, actual);               // Verify that expected and actual results are not Equal.
                                                                // Assert.AreNotEqual() evaluates whether given condition evaluates to False
                                                                // In this case, expected is 1.41289 but actual returns 912.3435 when compared, making the condition False which meets AreNotEqual() condition.
                                                                // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Max_82F_4F_91F_Return91F()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            float num1 = 82.43892F;
            float num2 = 4.23451F;
            float num3 = 91.21346F;
            float expected = 91.21346F;

            // Act 
            float actual = aclass.Max(num1, num2, num3);        // Returns 91.21346 as it is the largest between the three numbers

            // Assert
            Assert.AreNotEqual(expected, actual);               // Verify that expected and actual condition are not Equal
                                                                // Assert.AreNotEqual() evaluates whether given condition evaluates to False
                                                                // In this case, expected is 91.21346 and actual also returns 91.21346 when compared, making the condition True which does not meet AreNotEqual() condition. 
                                                                // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Fact_6_Return720()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 6;
            int expected = 720;    

            // Act
            int actual = aclass.Fact(num1);                     // Returns 720 as Factorial of 6 (6! = 6 * 5 * 4 * 3 * 2 * 1 = 720)

            // Assert
            Assert.AreEqual(expected, actual);                  // Verify that expected and actual results are Equal
                                                                // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                                // In this case, expected is 720 and actual also returns 720 when compared, making the condition True which meets AreEqual() condition. 
                                                                // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Fact_4_Return24()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 4;
            int expected = 42;

            // Act
            int actual = aclass.Fact(num1);                     // Returns 24 as Factorial of 4 (4! = 4 * 3 * 2 * 1 = 24)

            // Assert
            Assert.AreEqual(expected, actual);                  // Verify that expected and actual condition are Equal
                                                                // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                                // In this case, expected is 42 but actual returns 24 when compared, making the condition False which meets AreEqual() condition.
                                                                // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Fact_Neg5_Neg1()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = -5;
            int expected = -1;

            // Act
            int actual = aclass.Fact(num1);                     // -5! = not allowed because factorial can only perform on non-negative number

            // Assert
            Assert.AreEqual(expected, actual);                  // Verify that expected and actual condition are equal
                                                                // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                                // In this case, expected is -1 and actual also returns -1 when compared, making the condition True which meets AreEqual() condition.
                                                                // Thus, the assertion should Pass. 
        }

        [TestMethod]
        public void Gcd_10_6_Return2()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 10;
            int num2 = 6;
            int expected = 2;   

            // Act
            int actual = aclass.Gcd(num1, num2);        // Returns 2 as the greater common divisor (GCD) of num1 and num2

            // Assert
            Assert.AreEqual(expected, actual);          // Verify that expected and actual condition are equal
                                                        // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                        // In this case, expected is 2 and actual also returns 2 when compared, making the condition True which meets AreEqual() condition.
                                                        // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Gcd_18_12_Return6()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 18;
            int num2 = 12;
            int expected = 5;

            // Act
            int actual = aclass.Gcd(num1, num2);        // Returns 6 as the greater common divisor (GCD) of num1 and num2

            // Assert
            Assert.AreEqual(expected, actual);          // Verify that expected and actual condition are equal
                                                        // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                        // In this case, expected is 5 and actual returns 6 when compared, making the condition False which does not meet AreEqual() condition.
                                                        // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Gcd_0_2_ReturnNeg1()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 0;
            int num2 = 2;
            int expected = -1;

            // Act
            int actual = aclass.Gcd(num1, num2);        // Returns -1 since one of the numbers provided is 0 which mean it is not possible to divide both numbers without leaving any remainder

            // Assert
            Assert.AreEqual(expected, actual);          // Verify that expected and actual condition are Equal
                                                        // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                        // In this case, expected is -1 and actual also returns -1 when compared, making the condition True which meets AreEqual() condition.
                                                        // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Gcd_2_0_ReturnNeg1()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = 10;
            int num2 = 0;
            int expected = -1;

            // Act
            int actual = aclass.Gcd(num1, num2);        // Returns -1 since one of the number provided is 0 which mean it is not possible to divide both numbers without leaving any remainder

            // Assert
            Assert.AreEqual(expected, actual);          // Verify that expected and actual condition are Equal 
                                                        // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                        // In this case, expected is -1 and actual also returns -1 when compared, making the condition True which meets AreEqual() condition.
                                                        // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Gcd_Neg6_Neg3_ReturnNeg1()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            int num1 = -6;
            int num2 = -3;
            int expected = -1;

            // Act 
            int actual = aclass.Gcd(num1, num2);        // Returns -1 since both numbers provided are less than 1 (negative) which means it is not possible to divide both numbers without leaving any remainder

            // Assert
            Assert.AreEqual(expected, actual);          // Verify that expected and actual condition are Equal
                                                        // Assert.AreEqual() evaluates whether given condition evaluates to True
                                                        // In this case, expected is -1 and actual also returns -1 when compared, making the condition True which meets AreEqual() condition.
                                                        // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Checkasc_High_Low_Moderate_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "High";
            String s2 = "Low";
            String s3 = "Moderate";
            bool expected = true;

            // Act
            bool actual = aclass.Checkasc(s1, s2, s3);      // Returns True as each string are lexicographically (follows alphabetical order)
            
            // Assert
            Assert.IsTrue(expected == actual);              // Verify that expected and actual condition are True
                                                            // Assert.IsTrue() evaluates wehther given condition evaluates to True
                                                            // In this case, both expected and actual are True when compared, making the condition True which meets IsTrue() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Checkasc_Advanced_Beginner_Intermediate_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Advanced";
            String s2 = "Beginner";
            String s3 = "Intermediate";
            bool expected = false;

            // Act
            bool actual = aclass.Checkasc(s1, s2, s3);      // Return False as each string are lexicographically (follows alphabetical order)

            // Assert
            Assert.IsTrue(expected == actual);              // Verify that expected and actual condition are True
                                                            // Assert.IsTrue() evaluates whether the given condition evaluates to True
                                                            // In this case, expected is False but actual returns True when compared, making the condition False which meets IsTrue() condition.
                                                            // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Checkasc_Low_High_Moderate_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // Arrange 
            String s1 = "Low";
            String s2 = "High";
            String s3 = "Moderate";
            bool expected = true;

            // Act
            bool actual = aclass.Checkasc(s1, s2, s3);      // Returns True as each string are not lexicographically (follows alphabetical order)

            // Assert   
            Assert.IsFalse(expected == actual);            // Verify that expected and actual condition are False
                                                           // Assert.IsFalse() evaluates whether the given condition evaluates to False
                                                           // In this case, expected is True but actual is False when compared, making the condition False which meets IsFalse() condition.
                                                           // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Checkasc_Ellaria_Gilly_Shae_ReturnFalse()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Ellaria";
            String s2 = "Gilly";
            String s3 = "Shae";
            bool expected = true;

            // Act
            bool actual = aclass.Checkasc(s1, s2, s3);      // Returns True as each string are lexicographically (follows alphabetical order)

            // Assert
            Assert.IsFalse(expected == actual);             // Verify that expected and actual are not equal.
                                                            // Assert.IsFalse() evaluates whether the given condition evaluates to False.
                                                            // In this case, both expected and actual are True when compared, making the condition True which does not meet IsFalse() condition.
                                                            // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Lengthdiff_New_Orlean_Return3()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "New";
            String s2 = "Orlean";
            int expected = 3;

            // Act
            int actual = aclass.Lengthdiff(s1, s2);         // Returns 3 as the differences between the two strings

            // Assert
            Assert.AreEqual(expected, actual);              // Verify that expected and actual are equal
                                                            // Assertion.AreEqual() evaluates whether the given condition are equal or True
                                                            // In this case, both expected and actual are 3 when compared, making the condition True which meets AreEqual() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Lengthdiff_Domainican_Republic_Return1()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange 
            String s1 = "Dominican";
            String s2 = "Republic";
            int expected = 2;

            // Act
            int actual = aclass.Lengthdiff(s1, s2);         // Returns 1 as the differences between the two strings

            // Assert 
            Assert.AreEqual(expected, actual);              // Verify that expected and actual are equal
                                                            // Assertion.AreEqual() evaluates whether the given condition are equal or True
                                                            // In this case, expected is 2 and actual is 1 when compared, making the condition False which does not meet AreEqual() condition.
                                                            // Thus, the assertion should Fail.
        }

        [TestMethod]
        public void Lengthdiff_Elon_Musk_Return0()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Elon";
            String s2 = "Musk";
            int expected = 0;

            // Act
            int actual = aclass.Lengthdiff(s1, s2);         // Returns 0 as the differences between the two strings

            // Assert
            Assert.AreEqual(expected, actual);              // Verify that expected and actual are equal
                                                            // Assertion.AreEqual() evaluates whether the given condition are equal or True
                                                            // In this case, expected is 0 and actual is also 0 when compared, making the condition True which meets AreEqual() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]

        public void Concatcomp_Matthew_Forsythe_15_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert
            
            // Arrange
            String s1 = "Matthew";
            String s2 = "Forsythe";
            int len = 15;
            bool expected = true;

            // Act
            bool actual = aclass.Concatcomp(s1, s2, len);   // Returns True as the concatenated strings (s1 + s2) is less than or equal to provided length 

            // Assert
            Assert.IsTrue(expected == actual);              // Verify that expected and actual are True
                                                            // Assertion.IsTrue() evaluates whether the given condition are True 
                                                            // In this case, both expected and actual are True when compared, making the condition True which meets IsTrue() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]

        public void Concatcomp_Margaret_Andrew_8_ReturnFalse()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Margaret";
            String s2 = "Andrew";
            int len = 8;
            bool expected = true;

            // Act
            bool actual = aclass.Concatcomp(s1, s2, len);   // Returns False as the concatenated strings (s1 + s2) is less than or equal to provided length

            // Assert
            Assert.IsTrue(expected == actual);              // Verify that expected and actual are True
                                                            // Assertion.IsTrue() evaluates whether the given condition are True
                                                            // In this case, expected is True and actual is False when compared, making the condition False which does not meet IsTrue() condition.
                                                            // Thus, the assertion should Fail.
        }

        [TestMethod]

        public void Concatcomp_Hangsihak_Sin_12_ReturnFalse()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Hangsihak";
            String s2 = "Sin";
            int len = 12;
            bool expected = false;

            // Act
            bool actual = aclass.Concatcomp(s1, s2, len);   // Returns False as the concatenated strings (s1 + s2) is less than or equal to provided length

            // Assert
            Assert.IsFalse(expected == actual);             // Verify that expected and actual are False
                                                            // Assertion.IsFalse() evaluates whether the given condition are False.
                                                            // In this case, expected is False but actual is True when compared, making the condition False which meets IsFalse() condition.
                                                            // Thus, the assertion should Pass.
        }

        [TestMethod]
        public void Concatcomp_Saudi_Arabia_10_ReturnTrue()
        {
            Aclass aclass = new Aclass();

            // AAA convention: Arrange, Act, Assert

            // Arrange
            String s1 = "Saudi";
            String s2 = "Arabia";
            int len = 10;
            bool expected = false;

            // Act
            bool actual = aclass.Concatcomp(s1, s2, len);   // Returns True as the concatenated strings (s1 + s2) is less than or equal to provided length

            // Assert
            Assert.IsFalse(expected == actual);             // Verify that expected and actual are False
                                                            // Assertion.IsFalse() evaluates whether the given condition are False. 
                                                            // In this case, both expected and actual are False when compared, making it  becomes True in other word, it does not meet isFalse() condition
                                                            // Thus, the assertion should Fail.
        }

    }
}