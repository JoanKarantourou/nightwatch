# NightWatch — Roadmap (MVP placeholder)

> We’ll fill this progressively. For now, this is the Week 1–2 skeleton.

## Week 1 — Repo + Dev Foundations
- Create monorepo structure (`src/`, `tests/`, `infra/`, `docs/`).
- GitHub Actions skeleton (build + test).
- Local dev stack with `docker-compose.dev` (Kafka, Grafana, Prometheus, Tempo/OTEL collector placeholders).
- Service skeletons: `api-gateway` (.NET), `ingestor` (.NET), `webapp` (Next.js).

## Week 2 — Eventing + Observability
- Kafka topics + producers/consumers (contract + schemas).
- Wire OpenTelemetry (traces, metrics, logs) end-to-end.
- First Grafana dashboard.
- Minimal UI page that streams incidents.

## Definition of Done (MVP)
- `docker-compose.dev up` brings the stack up and demo flows end-to-end.
- `helm install nightwatch` works on kind/minikube.
- Terraform docs for AKS/EKS deploy (module skeleton OK).
