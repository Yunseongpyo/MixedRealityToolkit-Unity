﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Internal.Devices.UnityInput.OpenVR;
using Microsoft.MixedReality.Toolkit.Internal.Devices.WindowsMixedReality;

#if UNITY_EDITOR
using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities.Editor;
#endif

namespace Microsoft.MixedReality.Toolkit.Internal.Definitions.Devices
{
    /// <summary>
    /// Helper utility to manage all the required Axis configuration for platforms, where required
    /// </summary>
    public static class ControllerMappingLibrary
    {
        #region Controller axis mapping configuration

        #region Constants

        /// <summary>
        /// HTC Vive Controller: Left Controller Trackpad (2) Horizontal Movement<para/>
        /// Oculus Touch Controller: Axis2D.PrimaryThumbstick Horizontal Movement<para/>
        /// Valve Knuckles Controller: Left Controller Trackpad Horizontal Movement<para/>
        /// Windows Mixed Reality Motion Controller: Left Thumbstick Horizontal Movement<para/>
        /// </summary>
        public const string AXIS_1 = "AXIS_1";

        /// <summary>
        /// HTC Vive Controller: Left Controller Trackpad (2) Vertical Movement<para/>
        /// Oculus Touch Controller: Axis2D.PrimaryThumbstick Vertical Movement<para/>
        /// Valve Knuckles Controller: Left Controller Trackpad Vertical Movement<para/>
        /// Windows Mixed Reality Motion Controller: Left Thumbstick Vertical Movement<para/>
        /// </summary>
        public const string AXIS_2 = "AXIS_2";

        /// <summary>
        /// HTC Vive Controller: Right Controller Trackpad (2) Horizontal Movement<para/>
        /// Oculus Touch Controller: Axis2D.SecondaryThumbstick Horizontal Movement<para/>
        /// Valve Knuckles Controller: Right Controller Trackpad Horizontal Movement<para/>
        /// Windows Mixed Reality Motion Controller: Right Thumbstick Horizontal Movement<para/>
        /// </summary>
        public const string AXIS_4 = "AXIS_4";

        /// <summary>
        /// HTC Vive Controller: Right Controller Trackpad (2) Vertical Movement<para/>
        /// Oculus Touch Controller: Axis2D.SecondaryThumbstick Vertical Movement<para/>
        /// Valve Knuckles Controller: Right Controller Trackpad Vertical Movement<para/>
        /// Windows Mixed Reality Motion Controller: Right Thumbstick Vertical Movement<para/>
        /// </summary>
        public const string AXIS_5 = "AXIS_5";

        /// <summary>
        /// HTC Vive Controller: Left Controller Trigger (7) Squeeze<para/>
        /// Oculus Touch Controller: Axis1D.PrimaryIndexTrigger Squeeze<para/>
        /// Valve Knuckles Controller: Left Controller Trigger Squeeze<para/>
        /// Windows Mixed Reality Motion Controller: Left Trigger Squeeze<para/>
        /// </summary>
        public const string AXIS_9 = "AXIS_9";

        /// <summary>
        /// HTC Vive Controller: Right Controller Trigger (7) Squeeze<para/>
        /// Oculus Touch Controller: Axis1D.SecondaryIndexTrigger Movement Squeeze<para/>
        /// Valve Knuckles Controller: Right Controller Trigger Squeeze<para/>
        /// Windows Mixed Reality Motion Controller: Right Trigger Squeeze<para/>
        /// </summary>
        public const string AXIS_10 = "AXIS_10";

        /// <summary>
        /// HTC Vive Controller: Left Controller Grip Button (8) Squeeze<para/>
        /// Oculus Touch Controller: Axis1D.PrimaryHandTrigger Squeeze<para/>
        /// Valve Knuckles Controller: 	Left Controller Grip Average Squeeze<para/>
        /// Windows Mixed Reality Motion Controller: Left Grip Squeeze<para/>
        /// </summary>
        public const string AXIS_11 = "AXIS_11";

        /// <summary>
        /// HTC Vive Controller: Right Controller Grip Button (8) Squeeze<para/>
        /// Oculus Touch Controller: Axis1D.SecondaryHandTrigger Squeeze<para/>
        /// Valve Knuckles Controller: Right Controller Grip Average Squeeze<para/>
        /// Windows Mixed Reality Motion Controller: Right Grip Squeeze<para/>
        /// </summary>
        public const string AXIS_12 = "AXIS_12";

        /// <summary>
        /// Oculus Touch Controller: Axis1D.PrimaryIndexTrigger Near Touch<para/>
        /// </summary>
        public const string AXIS_13 = "AXIS_13";

        /// <summary>
        /// Oculus Touch Controller: Axis1D.SecondaryIndexTrigger Near Touch<para/>
        /// </summary>
        public const string AXIS_14 = "AXIS_14";

        /// <summary>
        /// Oculus Touch Controller: Touch.PrimaryThumbRest Near Touch<para/>
        /// </summary>
        public const string AXIS_15 = "AXIS_15";

        /// <summary>
        /// Oculus Touch Controller: Button.SecondaryThumbstick Near Touch<para/>
        /// </summary>
        public const string AXIS_16 = "AXIS_16";

        /// <summary>
        /// Windows Mixed Reality Motion Controller: Left Touchpad Horizontal Movement<para/>
        /// </summary>
        public const string AXIS_17 = "AXIS_17";

        /// <summary>
        /// Windows Mixed Reality Motion Controller: Left Touchpad Vertical Movement<para/>
        /// </summary>
        public const string AXIS_18 = "AXIS_18";

        /// <summary>
        /// Windows Mixed Reality Motion Controller: Right Touchpad Horizontal Movement<para/>
        /// </summary>
        public const string AXIS_19 = "AXIS_19";

        /// <summary>
        /// Windows Mixed Reality Motion Controller: Right Touchpad Vertical Movement<para/>
        /// Valve Knuckles Controller: Left Controller Index Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_20 = "AXIS_20";

        /// <summary>
        /// Valve Knuckles Controller: Right Controller Index Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_21 = "AXIS_21";

        /// <summary>
        /// Valve Knuckles Controller: Left Controller Middle Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_22 = "AXIS_22";

        /// <summary>
        /// Valve Knuckles Controller: Right Controller Middle Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_23 = "AXIS_23";

        /// <summary>
        /// Valve Knuckles Controller: Left Controller Ring Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_24 = "AXIS_24";

        /// <summary>
        /// Valve Knuckles Controller: Right Controller Ring Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_25 = "AXIS_25";

        /// <summary>
        /// Valve Knuckles Controller: Left Controller Pinky Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_26 = "AXIS_26";

        /// <summary>
        /// Valve Knuckles Controller: Right Controller Pinky Finger Cap Sensor<para/>
        /// </summary>
        public const string AXIS_27 = "AXIS_27";

        #endregion Constants

        #region InputAxisConfig

#if UNITY_EDITOR

        /// <summary>
        /// Get the InputManagerAxis data needed to configure the Input Mappings for a controller
        /// </summary>
        /// <returns></returns>
        public static InputManagerAxis[] UnityInputManagerAxes => new[]
        {
            new InputManagerAxis { Name = AXIS_1,  Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1  },
            new InputManagerAxis { Name = AXIS_2,  Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2  },
            new InputManagerAxis { Name = AXIS_4,  Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4  },
            new InputManagerAxis { Name = AXIS_5,  Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5  },
            new InputManagerAxis { Name = AXIS_9,  Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 9  },
            new InputManagerAxis { Name = AXIS_10, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 10 },
            new InputManagerAxis { Name = AXIS_11, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 11 },
            new InputManagerAxis { Name = AXIS_12, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 12 },
            new InputManagerAxis { Name = AXIS_13, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 13 },
            new InputManagerAxis { Name = AXIS_14, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 14 },
            new InputManagerAxis { Name = AXIS_15, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 15 },
            new InputManagerAxis { Name = AXIS_16, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 16 },
            new InputManagerAxis { Name = AXIS_17, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 17 },
            new InputManagerAxis { Name = AXIS_18, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 18 },
            new InputManagerAxis { Name = AXIS_19, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 19 },
            new InputManagerAxis { Name = AXIS_20, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 20 },
            new InputManagerAxis { Name = AXIS_21, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 21 },
            new InputManagerAxis { Name = AXIS_22, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 22 },
            new InputManagerAxis { Name = AXIS_23, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 23 },
            new InputManagerAxis { Name = AXIS_24, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 24 },
            new InputManagerAxis { Name = AXIS_25, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 25 },
            new InputManagerAxis { Name = AXIS_26, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 26 },
            new InputManagerAxis { Name = AXIS_27, Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 27 }
        };

#endif

        #endregion

        #endregion Controller axis mapping configuration

        #region Interaction Mapping Default Resolution

        // TODO: Find a better way.
        /// <summary>
        /// Retrieve the defaults for a specific controller type
        /// </summary>
        /// <param name="controllerType"></param>
        /// <param name="handedness"></param>
        /// <returns></returns>
        public static MixedRealityInteractionMapping[] GetMappingsForControllerType(SystemType controllerType, Handedness handedness)
        {
            if (controllerType == null)
            {
                return null;
            }

            if (controllerType == typeof(WindowsMixedRealityController))
            {
                return WindowsMixedRealityController.DefaultInteractions;
            }

            // For our open VR controllers we expect either left or right handedness
            if (handedness != Handedness.Left && handedness != Handedness.Right)
            {
                return null;
            }

            if (controllerType == typeof(OculusTouchController))
            {
                return handedness == Handedness.Left ? OculusTouchController.DefaultLeftHandedInteractions : OculusTouchController.DefaultRightHandedInteractions;
            }

            if (controllerType == typeof(ViveWandController))
            {
                return handedness == Handedness.Left ? ViveWandController.DefaultLeftHandedInteractions : ViveWandController.DefaultRightHandedInteractions;
            }

            if (controllerType == typeof(ViveKnucklesController))
            {
                return handedness == Handedness.Left ? ViveKnucklesController.DefaultLeftHandedInteractions : ViveKnucklesController.DefaultRightHandedInteractions;
            }

            if (controllerType == typeof(WindowsMixedRealityOpenVRController))
            {
                return handedness == Handedness.Left ? WindowsMixedRealityOpenVRController.DefaultLeftHandedInteractions : WindowsMixedRealityOpenVRController.DefaultRightHandedInteractions;
            }

            if (controllerType == typeof(GenericOpenVRController))
            {
                return handedness == Handedness.Left ? GenericOpenVRController.DefaultLeftHandedInteractions : GenericOpenVRController.DefaultRightHandedInteractions;
            }

            // Unconfigured Controller type
            return null;
        }

        #endregion Interaction Mapping Default Resolution
    }
}