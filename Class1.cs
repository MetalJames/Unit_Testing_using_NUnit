namespace NUnitDemonstration
{
    //Volodymyr Ruzhak
    //My apologies but this is my lab 2 and 3 together - I hope this is ok.
    public static class Triangle
    {
        public static string ValidTriangle(object firstAngle, object secondAngle, object thirdAngle)

        {
            // Here using my method to convert any object into integer
            int angle1 = ConvertToValidAngle(firstAngle);
            int angle2 = ConvertToValidAngle(secondAngle);
            int angle3 = ConvertToValidAngle(thirdAngle);

            string result;
            // Here I added extra check if any angle has a "0" but two other angles is equal to 180 in total
            // trying to make a mutant
            //if ((angle1 - angle2 - angle3) == 180
            //if (angle1 != 0 || angle2 != 0 || angle3 != 0)
            //if (angle1 == 0 || angle2 == 0 || angle3 == 0)
            //if ((angle1 != 0) || (angle2 != 0) || (angle3 != 0))
            //test 01 - failing valid triangle (ValidTriangle_ValidInput_ReturnsValidMessage_01)
            //if ((angle1 + angle2 + angle3) == 180 && ((angle1 != 0) && (angle2 != 0) && (angle3 == 0)))
            //if ((angle1 + angle2 + angle3) == 180 && (angle1 != 0) && (angle2 != 0) && (angle3 != 0))
            //test 02 - checking if two angles = to 180 and third angle = 0 will fail
            //if ((angle1 + angle2 + angle3) == 180 && ((angle1 == 0) && (angle2 != 0) && (angle3 != 0)))
            if ((angle1 + angle2 + angle3) == 180 && (angle1 != 0) && (angle2 != 0) && (angle3 != 0))
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
        // This function was added to verify null and string
        private static int ConvertToValidAngle(object angle)
        {
            if (angle == null || angle.Equals(" ") || angle.Equals(""))
            {
                //Volodymyr Ruzhak
                //test 03 - verifying that when the input angle is null, the method returns 60
                //and if sum or all three angles = 180 test will return "The triangle is valid"
                //return 60;
                return 0;
            }

            return Convert.ToInt32(angle);
        }
    }
}