// Read input URL from the console
Console.WriteLine("Enter a URL:");
string url = Console.ReadLine();

// Initialize default values for protocol, server, and resource
string protocol = "";
string server = "";
string resource = "";

// Find the protocol part (if any)
int protocolEndIndex = url.IndexOf("://");
if (protocolEndIndex != -1)
{
    protocol = url.Substring(0, protocolEndIndex);
    url = url.Substring(protocolEndIndex + 3); // Remove the protocol part
}

// Find the server part
int serverEndIndex = url.IndexOf('/');
if (serverEndIndex != -1)
{
    server = url.Substring(0, serverEndIndex);
    resource = url.Substring(serverEndIndex + 1); // Remove the server part and extract the resource part
}
else
{
    server = url; // If there's no '/', the rest of the URL is the server part
}

// Print the extracted parts
Console.WriteLine("[protocol] = \"" + protocol + "\"");
Console.WriteLine("[server] = \"" + server + "\"");
Console.WriteLine("[resource] = \"" + resource + "\"");
