# Spherus.ServiceResponse

This repository contains a simple generic Service Response using .NET Standard.

## How to use

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
<<<<<<< HEAD
```
=======


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
>>>>>>> fb8e7ce... Added nongeneric example
