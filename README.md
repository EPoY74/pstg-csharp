# PSTG — Pump Station Telemetry Gateway

[Русская версия](./README.ru.md)

PSTG is an **industrial telemetry gateway** and **monitoring backend** for pump stations, built with **C# / .NET** and designed around real **PLC**, **Modbus TCP**, and **industrial automation** constraints.

The project focuses on a practical engineering problem: collect telemetry from pump-station equipment, preserve raw data for diagnostics, normalize important signals, and build a clean foundation for monitoring, troubleshooting, trends, alarms, dashboards, APIs, and a future graphical interface. This project is **an industrial telemetry gateway and monitoring backend for pump stations, with a clear path toward a lightweight SCADA-like / HMI-style monitoring system**

---

## Why this project exists

In many industrial environments, telemetry exists but is still hard to use effectively in software:

- PLC data is available, but engineers still depend on manual checks or vendor tools.
- Raw Modbus registers are not convenient to consume directly in backend code.
- Monitoring, diagnostics, and storage concerns are often mixed together.
- Data freshness, quality, and traceability are rarely modeled explicitly.
- OT/IT integration usually starts as a one-off script instead of a maintainable system.

PSTG exists to solve that in a clean, engineering-oriented way.

---

## What PSTG is

PSTG is intended to become a solid base for:

- **industrial telemetry collection** from PLCs and field devices;
- **pump station monitoring** and diagnostics;
- preserving **raw register blocks** for traceability and troubleshooting;
- defining **normalized signals** with explicit metadata;
- later adding **alarms, trends, event logs, dashboards, and web APIs**;
- growing from a local monitoring tool into a more capable **industrial software / SCADA-adjacent backend**.

---

## Current repository status

This repository tracks the **C# rewrite of PSTG**.

The current development branch is focused on building the system correctly from the inside out:

- domain-first modeling;
- explicit entities / value objects for stations and signals;
- separation of domain, infrastructure, runtime, and presentation concerns;
- a worker/service-oriented execution model for polling and background processing;
- an architecture that can later support persistence, APIs, dashboards, alarms, and UI.

Where implementation is still evolving, PSTG should be read as an **active engineering prototype** and a **portfolio-grade industrial backend project**, not as a finished production SCADA product.

---

## Core engineering principles

### 1. Raw data first
Raw telemetry matters. For industrial diagnostics and troubleshooting, it is important to keep raw reads available instead of storing only interpreted values.

### 2. Normalized signals with explicit metadata
Signals should be described explicitly: function code, register address, register count, word order, data type, units, and later bit-level decoding when required.

### 3. Clean separation of concerns
The project aims to keep these concerns separate:

- **Domain** — what a station, signal, polling result, or quality state means.
- **Infrastructure** — how data is read, retried, stored, and logged.
- **Runtime / application flow** — how polling workflows and use cases are orchestrated.
- **Presentation** — future API, dashboard, HMI, or other UI layers.

### 4. Practical extensibility
The MVP can start with straightforward raw reads. The architecture should still allow the project to grow toward richer decoding, storage, alarms, trends, dashboards, and integration features without rewriting everything from scratch.

---

## Target use cases

PSTG is relevant for scenarios such as:

- local pump station monitoring;
- industrial telemetry gateway development;
- collecting PLC data for a backend service;
- creating a lightweight monitoring solution without committing to a heavy SCADA suite;
- prototyping internal dispatching, diagnostics, or engineering-support tools;
- demonstrating industrial backend, C#, .NET, Modbus TCP, and OT/IT integration skills for hiring and portfolio purposes.

---

## Why this repository matters for hiring

This project is intentionally positioned as a **portfolio repository for industrial backend and integration work**.

It demonstrates work on:

- **C# / .NET** solution structure;
- domain modeling;
- real industrial telemetry use cases;
- **Modbus TCP** and **PLC-oriented** data acquisition;
- backend architecture for monitoring systems;
- decisions shaped by real equipment constraints instead of tutorial assumptions;
- a realistic path from MVP to a more mature industrial software product.

For an interviewer, hiring manager, or team lead, PSTG is meant to show not only syntax knowledge, but also engineering judgment, system decomposition, and domain awareness.

---

## Scope and non-goals

### PSTG is
- an industrial telemetry project;
- a monitoring backend foundation;
- a pump-station software prototype;
- a C# / .NET portfolio repository with real domain context;
- a candidate foundation for future alarms, trends, dashboards, and UI.

### PSTG is not
- a finished enterprise SCADA platform;
- a certified safety system;
- a direct control system for safety-critical automation;
- a replacement for site-specific engineering validation, industrial testing, or regulatory review.

That distinction is deliberate.

---

## Technical direction

The long-term technical direction includes:

- background polling services;
- persistence for telemetry and metadata;
- a monitoring API;
- signal decoding and bit-level mapping where appropriate;
- data freshness / stale-data semantics;
- alarms and event journaling;
- dashboards and a graphical interface;
- packaging for practical local deployment.

This direction makes PSTG relevant not only as a coding exercise, but also as a compact **industrial monitoring backend**, **telemetry platform**, and possible foundation for a small **SCADA-like** monitoring solution.

---

## Development notes

This repository is under active development.

That means some parts of the architecture may evolve as the C# rewrite progresses, but the engineering direction remains stable:

- preserve raw telemetry;
- model signals explicitly;
- separate domain from infrastructure;
- keep the project maintainable and extensible;
- build something that is credible both as software and as an industrial engineering portfolio project.

---

## Author

**Евгений Петров / Evgenii Petrov**

- Email: `p174@mail.ru`
- Email: `epoy74@gmail.com`
- GitHub: `EPoY74`

---

## Disclaimer

This repository is provided for **learning, prototyping, portfolio demonstration, and engineering experimentation**.

It is **not** provided as a ready-to-deploy safety-critical control solution. Any real-world use in an industrial facility must be independently reviewed, tested, validated, and approved for the specific site, equipment, standards, and operating risks involved.

---

## License and attribution

### Recommended license set for this repository

- **Code:** [Apache License 2.0](./LICENSE)
- **Documentation, diagrams, register maps, configuration examples, screenshots, and other non-code materials:** [CC BY 4.0](./LICENSE-DOCS-DATA.md)
- **Additional attribution notice:** [NOTICE](./NOTICE)

### Official license references

- Apache License 2.0 — [official text](https://www.apache.org/licenses/LICENSE-2.0)
- CC BY 4.0 — [human-readable summary](https://creativecommons.org/licenses/by/4.0/) / [legal code](https://creativecommons.org/licenses/by/4.0/legalcode)

### Attribution expectations

If you reuse code or non-code materials from this project, please preserve copyright, license, and attribution notices.

If you reuse documentation, diagrams, register maps, screenshots, configuration examples, or other non-code assets, provide visible attribution to:

**Евгений Петров / Evgenii Petrov**

See [NOTICE](./NOTICE) for the recommended attribution wording.

---

## Language navigation

- English: [README.md](./README.md)
- Russian: [README.ru.md](./README.ru.md)
