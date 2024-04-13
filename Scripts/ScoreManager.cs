namespace a;

public class ScoreManager : IScoreManager {
    [SerializeField]
    private float score = 0;
    
    override public float GetScore() {
        return this.score;
    }
    
    override public float SetScore(float score) {
        return this.score = score;
    }
    
    override public float AddScore(float score) {
        return this.score += score;
    }
    
    override public float SubtractScore(float score) {
        return this.score -= score;
    }
    
    override public float ResetScore() {
        return this.score = 0;
    }
}