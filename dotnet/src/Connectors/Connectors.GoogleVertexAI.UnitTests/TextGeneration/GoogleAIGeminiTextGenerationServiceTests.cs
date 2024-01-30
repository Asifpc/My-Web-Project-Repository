﻿// Copyright (c) Microsoft. All rights reserved.

using Microsoft.SemanticKernel.Connectors.GoogleVertexAI;
using Microsoft.SemanticKernel.Services;
using Xunit;

namespace SemanticKernel.Connectors.GoogleVertexAI.UnitTests.TextGeneration;

public sealed class GoogleAIGeminiTextGenerationServiceTests
{
    [Fact]
    public void AttributesShouldContainModelId()
    {
        // Arrange & Act
        string model = "fake-model";
        var service = new GoogleAIGeminiTextGenerationService(model, "key");

        // Assert
        Assert.Equal(model, service.Attributes[AIServiceExtensions.ModelIdKey]);
    }
}
