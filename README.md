# InputTestFixtureBugSample
Sample repository reproducing error when running all unit tests when one of the fixtures uses InputTestFixture.

Test with InputTestFixture is successful when run in isolation, but fail when run with other tests.

To reproduce open TestRunner window in Unity Editor, select PlayMode tests, press Run All button.

Stacktrace:

```
Unhandled log message: '[Exception] ArgumentOutOfRangeException: Cannot be negative
Parameter name: value'. Use UnityEngine.TestTools.LogAssert.Expect
---
UnityEngine.InputSystem.Users.InputUser.set_listenForUnpairedDeviceActivity (System.Int32 value) (at Library/PackageCache/com.unity.inputsystem@1.5.1/InputSystem/Plugins/Users/InputUser.cs:406)
UnityEngine.InputSystem.PlayerInput.StopListeningForUnpairedDeviceActivity () (at Library/PackageCache/com.unity.inputsystem@1.5.1/InputSystem/Plugins/PlayerInput/PlayerInput.cs:1685)
UnityEngine.InputSystem.PlayerInput.OnDisable () (at Library/PackageCache/com.unity.inputsystem@1.5.1/InputSystem/Plugins/PlayerInput/PlayerInput.cs:1720)
```
