# Spherus.ServiceResponse

This repository contains a simple generic Service Response using .NET Standard.

## NuGet

[Link to the NuGet package](https://www.nuget.org/packages/Spherus.ServiceResponse/1.0.3)

**Package Manager: PM>** Install-Package Spherus.ServiceResponse -Version 1.0.3 <br />
**.NET CLI: >** dotnet add package Spherus.ServiceResponse --version 1.0.3

## How to use:

```csharp


//Generic use
ServiceResponse<string> HelloWorld()
{
	ServiceResponse<string> result = new ServiceResponse<string>();

	try
	{
		result.ObjectResult = "Hello World";
		result.Status.Code = 0;
		result.Status.Message = "Success";
	}
	catch (System.Exception ex)
	{
		result.ObjectResult = null;
		result.Status.Code = 1;
		result.Status.Message = ex.Message;
	}

	return result;
}


//Nongeneric use
ServiceResponse HelloWorld()
{
	ServiceResponse result = new ServiceResponse();

	try
	{
		result.Status.Code = 0;
		result.Status.Message = "Success";
	}
	catch (System.Exception ex)
	{
		result.Status.Code = 1;
		result.Status.Message = ex.Message;
	}

	return result;
}

```
