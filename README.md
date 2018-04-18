# webservices-activity1
# Technologies - c#,Json

Bonus Activity 7
I used the following API to find the location and codes of the country based on
phone number.
https://market.mashape.com/neutrinoapi/phone-validate
key: “create your own”

But you need to login and get your key for mashape.com and after getting the key
you need to change the Default.aspx.cs at this line
serviceRequest.Headers.Add("X-Mashape-Key", "key"); 
Run the code
Select US in dropdownlist and give this number in textbox like 4259791465.
 After click on the Ok button you will get the following response.
“The Number is True and the location is Washington State. Type is unknown and international calling code is 1. The local number is (425) 979-1465 and country code is US.”
 If you put wrong number with wrong country like UK with 4259791465. You will get the following response.
“The Number is False and international calling code is 44. The country code is GB.”

Thanks 
Khushboo Baheti
