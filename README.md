---

# Alphabet Checker Web API

This is a **.NET 8 Web API** that checks if a given string contains all the letters of the English alphabet. The API returns `true` if all letters are present and `false` otherwise.

---

## Prerequisites

Ensure the following tools and accounts are set up before getting started:

- **.NET 8 SDK**: [Download here](https://dotnet.microsoft.com/download/dotnet/8.0)
- **Azure account**: [Create one for free](https://azure.microsoft.com/en-us/free/)
- **Visual Studio 2022**: [Download here](https://visualstudio.microsoft.com/)

---

## Getting Started

### Project Structure

The project follows a clear, modular structure for easier understanding and development:


- **CheckingAlphabet**
  - **Controllers**
    - `AlphabetController.cs`: Handles HTTP requests related to alphabet operations.
  - **Services**
    - `AlphabetService.cs`: Implementation of alphabet-related services.
    - `IAlphabetService.cs`: Interface for `AlphabetService`.
  - Configuration files: `appsettings.json`, `appsettings.Development.json`
  - `Program.cs`: Entry point of the application.

- **CheckingAlphabet.Tests**
  - `AlphabetServiceTests.cs`: Unit tests for `AlphabetService`.




### Clone the Repository

To get started, clone the repository and navigate to the project directory:

```bash
git clone https://github.com/VijaykumarJakune/CheckingAlphabet.git
cd CheckingAlphabet
```

### Build and Run the API

1. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

2. **Build the project**:
   ```bash
   dotnet build
   ```

3. **Run the API**:
   ```bash
   dotnet run
   ```

The API will be available at:  
`https://localhost:44382`

---

## API Documentation with Swagger

This project includes **Swagger UI** for detailed, interactive API documentation. Once the API is running, you can access the Swagger interface at:

**URL**:  
`https://localhost:44382/swagger`

### Features of Swagger:

- View all available endpoints.
- Explore request and response schemas.
- Test API endpoints interactively.

**Example:
Swagger UI showing /api/alphabet/check endpoint with input and response example.**:  


![image](https://github.com/user-attachments/assets/ae160607-f10d-4ef1-843e-512959e4c361)


---

## API Endpoints

All endpoints are documented in the **Swagger UI** at `https://localhost:44382/swagger`. 

### **Check Alphabet**

**HTTP GET** `/api/alphabet/check`

**Parameters**: `input` (string) - The string to be checked for all alphabets.

**Response**: `true/false`


### Example Request

```
GET /api/alphabet/check?input=The five boxing wizards jump quickly
Response: true
```



## Test Cases

1. Input: `"The alphabet checking tests running"`
   - Output: `false`

2. Input: `"The quick brown fox jumps over the lazy dog"`
   - Output: `true`

3. Input: `"1234567890^!@#$%&*()"`
   - Output: `false`
     
4. Input: `"abcdefghijklmnopqrstuvwxyz"`
   - Output: `true`
     
5. Input: `"ABCDEFGHIJKLMNOPQRSTUVWXYZ"`
   - Output: `true`
     
6. Input: `""`
   - Output: `false`
     
7. Input: `"s"`
   - Output: `false`
     
8. Input: `"asda@$$ABS"`
   - Output: `false`


## Deployment on Azure

### Create an Azure App Service using Azure Portal

1. **Login to Azure Portal:**
   - Go to Azure Portal and log in with your Azure account.

2. **Create a Resource Group:**
   - Navigate to **Resource groups**.
   - Click **Create**.
   - Enter the **Resource group name** (e.g., `CheckingAlphabetRG`) and select a **Region**.
   - Click **Review + create** and then **Create**.

3. **Create an App Service Plan:**
   - Navigate to **App Services**.
   - Click **Create**.
   - Select **Create new** under **App Service plan**.
   - Enter the **App Service plan name** (e.g., `CheckingAlphabetPlan`) and select the **Pricing tier** (e.g., B1).

4. **Create a Web App:**
   - In the **App Services** creation form, enter the **Web App name** (e.g., `CheckingAlphabetApp`).
   - Select the **Runtime stack** as `.NET 8`.
   - Select the **Region**.
   - Click **Review + create** and then **Create**.

### Deploy the API using Visual Studio

1. Open the solution in Visual Studio.

2. Right-click on the `CheckingAlphabet` project in Solution Explorer and select **Publish**.

3. In the **Publish** dialog, select **Azure** and click **Next**.

4. Select **Azure App Service (Windows)** and click **Next**.

5. Select your existing App Service or create a new one:
    - If creating a new one, follow the prompts to set up the App Service.

6. Click **Finish** to complete the setup.

7. Click **Publish** to deploy the application to Azure.

The API will be available at `https://<your-app-name>.azurewebsites.net`.

### Alternative approach of Deployment - Using Azure CLI

1. **Login to Azure**:
   ```bash
   az login
   ```

2. **Create a Resource Group**:
   ```bash
   az group create --name CheckingAlphabetResourceGroup --location <location>
   ```

3. **Create an App Service Plan**:
   ```bash
   az appservice plan create --name CheckingAlphabetPlan --resource-group CheckingAlphabetResourceGroup --sku FREE
   ```

4. **Create a Web App**:
   ```bash
   az webapp create --name CheckingAlphabetApp --resource-group CheckingAlphabetResourceGroup --plan CheckingAlphabetPlan
   ```

5. **Deploy the App**:
   ```bash
   az webapp deploy --resource-group CheckingAlphabetResourceGroup --name CheckingAlphabetApp --src-path .
   ```

---

## Error Handling

To improve the user experience, the API implements the following error handling:

1. **Validation Errors**:
   - If the input is null or empty, the API returns a `400 Bad Request` with a meaningful error message.

2. **Server Errors**:
   - For unexpected failures, a `500 Internal Server Error` is returned with a generic message.

---

## Scalability

To ensure the application can handle traffic spikes:

- **Auto-scaling**: Use Azure's App Service scaling features.
- **Load Balancing**: Integrate with Azure Front Door or Application Gateway.
- **Monitoring**: Use Azure Monitor to set up alerts for performance metrics like request latency and response times. This ensures proactive scaling.

---

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.


---



---
