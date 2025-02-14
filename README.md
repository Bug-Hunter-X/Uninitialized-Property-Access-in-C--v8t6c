# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's been assigned a value.  Uninitialized properties can lead to unexpected behavior, especially with reference types (which will default to null). The provided code examples illustrate the problem and its solution.

**Bug:** Accessing the `MyProperty` before assigning a value results in an unexpected default value (0 for integers).

**Solution:**  Initialize the property either in the constructor or explicitly before accessing it.