# Checkout
a simple client and service for a supermarket checkout basket total


## Instructions

### Setup

1. Clone or download the repo
2. Open Checkout.sln in Visual Studio 2017
3. Build solution
4. Deploy CheckoutService on IIS(Express), right clicking the project and selecting 'view in browser' should suffice
5. Update the service address in the App.config of CheckoutClient
6. Run CheckoutClient


### Using the program
1. Program prompts 'Enter SKU or type checkout:'
2. User enters SKU, for example 'A99'
3. Program prompts 'Enter quantity (1):', an empty response defaults to 1 for convenience
4. User enters quantity, for example 2
5. Program asks for another item 'Enter SKU or type checkout:'
6. User types 'checkout' to end item entry
7. Program displays total: 1


### Example output

```
Enter SKU or type checkout:
A99
Enter quantity (1):
7
Enter SKU or type checkout:
C40
Enter quantity (1):

Enter SKU or type checkout:
checkout
The basket total is: 4.90
```
