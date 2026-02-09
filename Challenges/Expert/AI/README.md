# Expert Coding Challenge – Rate Limiter Simulation

## Objective

Implement a rolling-window rate-limiting mechanism using precise logical reasoning in C#.

---

## Task Description

You are given a list of API request timestamps made by a single client.

The system enforces a rate limit of **5 requests per rolling 60-second window**.

A request must be rejected if more than five requests occur within any rolling 60-second period.

Your task is to calculate:
- The number of requests that are allowed
- The number of requests that are rejected

---

## Requirements

- Requests may not be evenly spaced
- Requests may not be provided in chronological order
- The rate limit applies to a rolling window, not fixed time intervals
- Do not change the method signature

---
