﻿// <copyright file="Class1Tests.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace DemoLibrary.Tests;

/// <summary>
/// Tests for the <see cref="Class1"/> class.
/// </summary>
public class Class1Tests
{
    [Fact]
    public void Add_WithInput_ReturnsSum()
    {
        // Arrange
        var sut = new Class1();

        // Act
        var actual = sut.Add(1, 2);

        // Assert
        actual.Should().Be(3);
    }
}
