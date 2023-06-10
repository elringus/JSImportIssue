import { dotnet } from './dotnet.js'

export function importString() {
    return "Hello!";
}

const { getAssemblyExports, getConfig } = await dotnet.create();
await dotnet.run();
const exports = await getAssemblyExports(getConfig().mainAssemblyName);

console.log(exports.Program.GetImportedString());
