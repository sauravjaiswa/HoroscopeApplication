node('windows'){
    // stage('checkout'){
    //     checkout(this);
    // }
    // stage('pull git'){
    //     sh 'git checkout -master'
    // }
    stage('test'){
        echo 'Chal gaya'
     }
      stage('build') {        
        'dotnet build ./HoroscopeApplication.sln'
     }

    stage('Test') {
         'dotnet test ./HoroscopeApplication.Test/ /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=../coverage.cobertura.xml'
    }

    stage('publish test') {
        publish()
    }

    stage('Sonar'){
        'dotnet sonarscanner end /d:sonar.login="WGID_Sonar_Token"'
    }
}



def publish(Map args = [:]) {
    standardLineCoverageTarget = 0
    standardMethodCoverageTarget = 0
    standardClassCoverageTarget = 0

    coberturaReportFile = args.coberturaReportFile ?: 'coverage.cobertura.xml'
    lineCoverageTarget = args.lineCoverageTarget ?: standardLineCoverageTarget
    methodCoverageTarget = args.methodCoverageTarget ?: standardMethodCoverageTarget
    classCoverageTarget = args.classCoverageTarget ?: standardClassCoverageTarget

    isBelowStandardCoverageTargets = lineCoverageTarget < standardLineCoverageTarget ||
                                     methodCoverageTarget < standardMethodCoverageTarget ||
                                     classCoverageTarget < standardClassCoverageTarget

    cobertura(coberturaReportFile: coberturaReportFile,
              lineCoverageTargets: codeCoverageTargets(healthy: 0, unhealthy: lineCoverageTarget, unstable: lineCoverageTarget * 0.75),
              methodCoverageTargets: codeCoverageTargets(healthy: 0, unhealthy: methodCoverageTarget, unstable: methodCoverageTarget * 0.75),
              classCoverageTargets: codeCoverageTargets(healthy: 0, unhealthy: classCoverageTarget, unstable: classCoverageTarget * 0.75),
              maxNumberOfBuilds: 0,
              autoUpdateHealth: isBelowStandardCoverageTargets,
              autoUpdateStability: isBelowStandardCoverageTargets)
}

String codeCoverageTargets(Map args) {
    return "${args.healthy}, ${args.unhealthy}, ${args.unstable}"
}

