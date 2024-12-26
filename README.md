# Uninitialized Property Access in C#

This repository demonstrates a common error in C# where a NullReferenceException can occur when accessing a class property that hasn't been initialized.  The `bug.cs` file contains the problematic code, while `bugSolution.cs` provides a corrected version.

## Problem

In C#, class properties are reference types, meaning they can be null.  If you try to use a property before giving it a value, a `NullReferenceException` will be thrown.

## Solution

To fix this, make sure to initialize the property either in the constructor or before attempting to use it.
