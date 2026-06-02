# 🔒 Spec-Driven DevSecOps for Banking APIs (.NET 8)

## Resumen Ejecutivo

Este proyecto demuestra una implementación empresarial de DevSecOps para APIs bancarias utilizando .NET 8, GitHub Advanced Security, GitHub Actions y Azure DevOps.

El enfoque utiliza OpenAPI como contrato de seguridad central, permitiendo que las validaciones de seguridad sean generadas y ejecutadas automáticamente durante el ciclo de desarrollo.

## Objetivos

* Implementar DevSecOps Shift-Left.
* Integrar seguridad desde el diseño de la API.
* Automatizar controles de OWASP API Security Top 10.
* Detectar vulnerabilidades antes del despliegue.
* Generar evidencia de cumplimiento de seguridad.

## Componentes Tecnológicos

### Desarrollo

* ASP.NET Core 8
* OpenAPI / Swagger
* JWT Authentication

### DevSecOps

* GitHub Actions
* GitHub Advanced Security
* CodeQL
* Secret Scanning
* Dependabot
* Gitleaks
* Spectral
* OWASP ZAP

### Gestión

* Azure DevOps Boards
* Azure DevOps Dashboards

### Infraestructura

* Docker
* Azure App Service

## Pipeline DevSecOps

1. Pull Request
2. Build y Unit Tests
3. OpenAPI Governance (Spectral)
4. SAST (CodeQL)
5. Secret Detection (GitHub Secret Scanning + Gitleaks)
6. Dependency Analysis (Dependabot)
7. DAST (OWASP ZAP)
8. Compliance Report
9. Deployment

## Beneficios

* Seguridad automatizada
* Reducción de riesgos
* Evidencia de auditoría
* Integración continua
* Despliegue continuo
* Gobierno de APIs

## Resultado Esperado

Toda modificación de código debe pasar por controles automáticos de calidad y seguridad antes de llegar a producción, garantizando trazabilidad, cumplimiento y reducción de vulnerabilidades.
