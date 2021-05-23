# STBDotNet

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/hrntsm/STBDotNet/.NET%20Core)](https://github.com/hrntsm/STBDotNet/actions?query=workflow%3A%22.NET+Core%22)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/9d82da70572843968d00f39295c8125d)](https://www.codacy.com/gh/hrntsm/STBDotNet/dashboard?utm_source=github.com&utm_medium=referral&utm_content=hrntsm/STBDotNet&utm_campaign=Badge_Grade)
[![Maintainability](https://api.codeclimate.com/v1/badges/500f11fa2a460e5d5c62/maintainability)](https://codeclimate.com/github/hrntsm/STBDotNet/maintainability)
[![codecov](https://codecov.io/gh/hrntsm/STBDotNet/branch/develop/graph/badge.svg?token=SMTSZSDXVL)](https://codecov.io/gh/hrntsm/STBDotNet)

STBDotNet is a .NET library for ST-Bridge.

SDK Document is blow link.  
[STBDotNet SDK Documents](https://hiron.dev/STBDotNet/docs/index.html)

Nuget Package can download [here](https://www.nuget.org/packages/STBDotNet/)

## This library Work in Progress

We are currently developing more additional useful features.

## Usage

### Serialize & output ST-Bridge file

By specifying the StbElements class and the path you want to output, the st-bridge data will be output.
It returns a bool indicating the success or failure of the output.

```cs
STBDotNet.StbElements model = hoge; // Set ST-Bridge data
var sr = new STBDotNet.Serialization.Serializer();
bool result = sr.Serialize(model, outPath);
```

### Deserialize ST-Bridge file

Input the path to the stb file, and the loaded data will be serialized and retrieved as the StbElements class.

Deserializer returns as an object type, so cast it in the same version as the STB file.
If you are using version 2.0.2, it is as follows.

```cs
var sr = new STBDotNet.Serialization.Serializer();
var model = (v202.ST_BRIDGE)sr.Deserialize(stbPath);
```

## What is ST-Bridge

Quote from [building SMART Japan Structural Design Subcommittee](https://en.building-smart.or.jp/meeting/buildall/structural-design/) doing making specifications of ST-Bridge.

> ST Bridge is the standardized format for data sharing in Japan’s structural engineering industry.
>
> - Simpler to use than IFC due to the clearly defined the range of use
> - Integrate Japanese original methods of drawing methodology (Grids, part placement and section annotations, reinforcement information)
> - Aim for coordination between domestic structural applications, building skeleton surveying applications, 3D Object CAD

## Contact information

[![Twitter](https://img.shields.io/twitter/follow/hiron_rgkr?style=social)](https://twitter.com/hiron_rgkr)

- HP : [https://hiron.dev](https://hiron.dev)
- Mail : support(at)hrntsm.com
  - change (at) to @

## License

STBDotNet is licensed under the [MIT](https://github.com/hrntsm/STBDotNet/blob/main/LICENSE) license.  
Copyright© 2021, hrntsm
