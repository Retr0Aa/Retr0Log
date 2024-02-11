project "Retr0Log"
    kind "SharedLib"
    language "C#"
    targetdir "bin/%{cfg.buildcfg}"

    files { "**.cs" }

    filter "configurations:Debug"
      defines { "DEBUG" }
      symbols "On"

    filter "configurations:Release"
      defines { "RELEASE" }
      optimize "On"