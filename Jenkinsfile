
sh 'dotnet build ./HoroscopeApplication.sln'


stage('Test'){
sh 'dotnet test ./HoroscopeApplication.Test/ /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=../coverage.cobertura.xml'
}

stage('publish test'){
publish()
}


def publish(Map args = [:]) {

    standardLineCoverageTarget = 80
    standardMethodCoverageTarget = 80
    standardClassCoverageTarget = 90
    
    coberturaReportFile = args.coberturaReportFile ?: 'coverage.cobertura.xml'
    lineCoverageTarget = args.lineCoverageTarget ?: standardLineCoverageTarget
    methodCoverageTarget = args.methodCoverageTarget ?: standardMethodCoverageTarget
    classCoverageTarget = args.classCoverageTarget ?: standardClassCoverageTarget

    isBelowStandardCoverageTargets = lineCoverageTarget < standardLineCoverageTarget ||
                                     methodCoverageTarget < standardMethodCoverageTarget ||
                                     classCoverageTarget < standardClassCoverageTarget

    cobertura(coberturaReportFile: coberturaReportFile,
              lineCoverageTargets: codeCoverageTargets(healthy: 90, unhealthy: lineCoverageTarget, unstable: lineCoverageTarget * 0.75),
              methodCoverageTargets: codeCoverageTargets(healthy: 90, unhealthy: methodCoverageTarget, unstable: methodCoverageTarget * 0.75),
              classCoverageTargets: codeCoverageTargets(healthy: 100, unhealthy: classCoverageTarget, unstable: classCoverageTarget * 0.75),
              maxNumberOfBuilds: 0,
              autoUpdateHealth: isBelowStandardCoverageTargets,
              autoUpdateStability: isBelowStandardCoverageTargets)
}

String codeCoverageTargets(Map args) {
    return "${args.healthy}, ${args.unhealthy}, ${args.unstable}"
}