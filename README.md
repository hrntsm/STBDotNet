# STBDotNet

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/hrntsm/STBDotNet/.NET%20Core)](https://github.com/hrntsm/STBDotNet/actions?query=workflow%3A%22.NET+Core%22)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/9d82da70572843968d00f39295c8125d)](https://www.codacy.com/gh/hrntsm/STBDotNet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=hrntsm/STBDotNet&amp;utm_campaign=Badge_Grade)
[![Maintainability](https://api.codeclimate.com/v1/badges/500f11fa2a460e5d5c62/maintainability)](https://codeclimate.com/github/hrntsm/STBDotNet/maintainability)
[![codecov](https://codecov.io/gh/hrntsm/STBDotNet/branch/develop/graph/badge.svg?token=SMTSZSDXVL)](https://codecov.io/gh/hrntsm/STBDotNet)

STBDotNet is a .NET library for ST-Bridge.

SDK Document is blow link.

[STBDotNet SDK Documents](https://hrntsm.github.io/STBDotNet/html/861e8c8d-d9f5-fa0a-ea9f-5e116362eee0.htm#!)

## This library Work in Progress

We are currently developing more additional useful features.

## Usage

### Serialize & output ST-Bridge file

By specifying the StbElements class and the path you want to output, the st-bridge data will be output.
It returns a bool indicating the success or failure of the output.
```cs
STBDotNet.StbElements model = hoge; // Set ST-Bridge data
var serializer = new STBDotNet.Serialization.Serializer();
bool result = serializer.Serialize(model, outPath);
```

### Deserialize ST-Bridge file

Input the path to the stb file, and the loaded data will be serialized and retrieved as the StbElements class.
```cs
var serializer = new STBDotNet.Serialization.Serializer();
StbElements model = serializer.Deserialize(stbPath);
```

## What is ST-Bridge

Quote from [building SMART Japan Structural Design Subcommittee](https://en.building-smart.or.jp/meeting/buildall/structural-design/) doing making specifications of ST-Bridge.

> ST Bridge is the standardized format for data sharing in Japan’s structural engineering industry.
> - Simpler to use than IFC due to the clearly defined the range of use
> - Integrate Japanese original methods of drawing methodology (Grids, part placement and section annotations, reinforcement information)
> - Aim for coordination between domestic structural applications, building skeleton surveying applications, 3D Object CAD

## Contact information

[![Twitter](https://img.shields.io/twitter/follow/hiron_rgkr?style=social)](https://twitter.com/hiron_rgkr)
 - HP : [https://hrntsm.github.io/](https://hrntsm.github.io/)
 - Mail : support(at)hrntsm.com
    - change (at) to @
  
## License

STBDotNet is licensed under the [MIT](https://github.com/hrntsm/STBDotNet/blob/main/LICENSE) license.  
Copyright© 2020, hrntsm
