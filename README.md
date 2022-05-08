# HabboDiffieDumper

Dumps Diffie-Hellman handshakes from Habbo. This is part of a bigger research project.

## Usage

Modify [the constants](DiffieDumper/Constants.cs) before you run the project.

## Output

The output is placed in a `session_timestamp.dat` file with the following binary format.

| Name                 | Type                   |
|----------------------|------------------------|
| Index                | UInt32 (Little endian) |
| Encrypted Generator  | byte[256]              |
| Encrypted Prime      | byte[256]              |
| Encrypted Public Key | byte[256]              |

Each entry is exactly **772** bytes, which should allow for parallel processing.

## Benchmark

On an 1 gbit server with 8 physical cores (16 with HT) a speed of **1622** handshakes **per second**.