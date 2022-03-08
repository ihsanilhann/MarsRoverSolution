using System.Collections.Generic;

namespace MarsRoverProject
{
    // Instead of generating instance at each time, we create instance for possible
    // rotations and use in case of neccesity
    public static class RotationFactory
    {
        // Rotational list
        private static Dictionary<char, IRotation> InstanceDict = null;

        public static IRotation GetInstance(string c)
        {
            // Fill the list in in case of emptiness
            if (InstanceDict == null)
            {
                // Four possible main rotation
                InstanceDict = new Dictionary<char, IRotation>(4);

                // North/East/South/West
                InstanceDict['N'] = NorthRotation.GetInstance();
                InstanceDict['E'] = EastRotation.GetInstance();
                InstanceDict['S'] = SouthRotation.GetInstance();
                InstanceDict['W'] = WestRotation.GetInstance();
            }

            char key = c.ToUpper()[0];
            if(InstanceDict.ContainsKey(key))
            {
                // Get the object
                return InstanceDict[key];
            }
            else
            {
                throw new InvalidCommandException("Undefined key: \"" + key + "\"");
            }
        }
    }
}
