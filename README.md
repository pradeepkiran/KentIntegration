# KentIntegration
Webhooks for Kent Cam Integration

Install nuget package for the entity framework i.e.

Install-Package Microsoft.EntityFrameworkCore Install-Package Microsoft.EntityFrameworkCore.Tools Install-Package Microsoft.EntityFrameworkCore.SqlServer

Run the Scaffold dbcontext as
Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\t751474\source\repos\Employee\ClassLibrary1\Database1.mdf;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables "employee_name" -ContextDir Context -Context BlogContext -ContextNamespace New.Namespace
