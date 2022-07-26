node('windows'){
    // stage('checkout'){
    //     checkout(this);
    // }
    // stage('pull git'){
    //     sh 'git checkout -master'
    // }
    stage('build') {
        sh 'dotnet build ./HoroscopeApplication.sln'
    }

    stage('Test') {
        sh 'dotnet test ./HoroscopeApplication.Test/ /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=../coverage.cobertura.xml'
    }

    stage('publish test') {
        publish()
    }
}

def checkout(script) {
    try {
      
            script.checkout([
                $class: 'GitSCM',
                branches: 'master',
                extensions: [
                    [$class: 'CloneOption', noTags: false, shallow: false, depth: 0, reference: ''],
                    [$class: 'LocalBranch', localBranch: env.BRANCH_NAME],
                ],
                userRemoteConfigs: script.scm.userRemoteConfigs
            ])
            // workaround for root user created files
            sh 'sudo git reset --hard && sudo git clean -fdx'
         
        
    } catch (error) {        
        cleanWs()
        throw error
    }
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

