// SPDX-License-Identifier: MIT
// Copyright (c) 2025. Csaba Dudas (CsabaDu)

namespace CsabaDu.DynamicTestData.Lite.MSTest.DynamicDataSources;

/// <summary>
/// Represents an abstract base class for dynamically generating object arrays  based on the provided arguments code.
/// </summary>
/// <remarks>This class extends <see cref="DynamicObjectArraySource"/> and is specifically  designed to work with
/// test case scenarios, using <see cref="PropsCode.TestCaseName"/>  as a key property. It provides a foundation for
/// creating dynamic object arrays  tailored to specific use cases.</remarks>
/// <param name="argsCode"></param>
public abstract class DynamicCompleteObjectArraySource(ArgsCode argsCode)
: DynamicObjectArraySource(argsCode, PropsCode.TestCaseName);