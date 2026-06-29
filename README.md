# demo-unity-APIGateway

各種 Web API を Unity から呼び出すためのクライアント実装を集めたデモプロジェクト。
`UnityWebRequest` + [UniTask](https://github.com/Cysharp/UniTask) による非同期 API 呼び出しを、
API ごとに薄いクライアントとして分離して実装している。

> **Status: WIP（開発中）**
> 一部の API クライアントは雛形のみ／未実装です（下表「状態」を参照）。

## 動作環境

- Unity **6000.0.30f1**
- Universal Render Pipeline (URP) 17.0.3
- [UniTask](https://github.com/Cysharp/UniTask)（`Packages/manifest.json` で Git 参照）
- Input System 1.11.2

## 構成

```
Assets/Scripts/
├── APIGateway/            # API クライアント群（asmdef: APIGateway）
│   ├── GitHub/            # GitHub リポジトリ情報の取得
│   ├── OpenAI/            # ChatGPT (Chat Completions) 連携
│   ├── Wikipedia/         # Wikipedia REST API
│   └── ZipCloud/          # 郵便番号 → 住所検索（zipcloud）
└── Composition/           # 合成層（asmdef: Composition）
    ├── APIConfigSO.cs     # API キー保持用 ScriptableObject
    └── EntryPoint.cs      # 起動時に API を呼ぶサンプル MonoBehaviour
```

`APIGateway` は外部依存のない API クライアント層、`Composition` がそれらと設定（`APIConfigSO`）を
組み合わせるエントリ層、という一方向の依存構成。

## API クライアントの状態

| API | 名前空間 | 状態 | 認証 |
|-----|----------|------|------|
| ZipCloud（郵便番号→住所） | `APIGateway.ZipCode` | ✅ 実装済み（`EntryPoint` から呼び出し） | 不要 |
| GitHub（リポジトリ情報） | `APIGateway.GitHub` | ✅ 実装済み（呼び出しはコメントアウト） | 不要（公開リポジトリ） |
| OpenAI ChatGPT | `APIGateway.OpenAI` | 🚧 雛形のみ（本体未実装） | API キー必須 |
| Wikipedia | `APIGateway.Wikipedia` | 🚧 雛形のみ（未実装） | 不要 |

## 使い方

1. Unity 6000.0.30f1 で本プロジェクトを開く（初回は UniTask の取得が走る）。
2. `Assets/Scenes/SampleScene.unity` を開く。
3. `EntryPoint` がアタッチされた GameObject の `APIConfigSO` 参照を確認する。
4. Play すると、既定で ZipCloud に郵便番号 `1000001`（東京都千代田区千代田）を問い合わせ、
   結果を Console に出力する。

GitHub クライアントを試す場合は `EntryPoint.cs` のコメントアウトされた `Start()` を有効化する。

## API キーの取り扱い（注意）

`APIConfigSO`（`Assets/API Config.asset`）に API キーを保持する設計です。
**この asset はリポジトリに追跡されている**ため、キーを書き込むとそのままコミットされる点に注意してください。
鍵を扱う場合は、asset を `.gitignore` 化する／実行時に環境変数等から注入する、などの対策を推奨します。

## ライセンス

未定。
