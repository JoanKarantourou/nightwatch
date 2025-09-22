# NightWatch
Cloud-native real-time incident feed & anomaly radar.

## Why it exists
Showcase end-to-end skills (event-driven .NET, Kafka, OpenTelemetry, Next.js, K8s, Helm, Terraform) with a <5-minute demo and production-like architecture.

## Status
Work in progress — Week 1 (repo structure, CI, dev stack).

## MVP checklist
- [ ] `docker-compose.dev up` brings the stack up
- [ ] `helm install nightwatch` works on local K8s
- [ ] Cloud deploy via Terraform (AKS/EKS) documented
- [ ] End-to-end observability (OTEL → Grafana)
- [ ] Security: OIDC login, RBAC, audit trail

## Tech stack
- Backend: .NET (C#), Kafka
- Frontend: Next.js / React
- Observability: OpenTelemetry, Grafana, Prometheus
- Platform: Docker, Kubernetes, Helm, Terraform
- CI/CD: GitHub Actions

## Quickstart (placeholder)
- Dev env instructions will land in Week 1.  
- For now: see `docs/ROADMAP.md`.

## Repo layout (grows with the project)
```
infra/           # IaC + Helm charts
src/             # services & web
tests/           # automated tests
docs/            # roadmap, ADRs, runbooks, dashboards
  adr/
  runbooks/
  dashboards/
.github/workflows/  # CI pipelines
```

## Roadmap
See [docs/ROADMAP.md](docs/ROADMAP.md).

## Contributing
Feature branches + conventional commits. PR must pass CI.

## License
MIT — see [LICENSE](LICENSE).
