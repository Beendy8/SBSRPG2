using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class SerializedDict<K, V> : SerializedDict<K, V, K, V>
{
    /// <summary>
    ///     Conversion to serialize a key
    /// </summary>
    /// <param name="key">The key to serialize</param>
    /// <returns>The Key that has been serialized</returns>
    public override K SerializeKey(K key)
    {
        return key;
    }

    /// <summary>
    ///     Conversion to serialize a value
    /// </summary>
    /// <param name="val">The value</param>
    /// <returns>The value</returns>
    public override V SerializeValue(V val)
    {
        return val;
    }

    /// <summary>
    ///     Conversion to serialize a key
    /// </summary>
    /// <param name="key">The key to serialize</param>
    /// <returns>The Key that has been serialized</returns>
    public override K DeserializeKey(K key)
    {
        return key;
    }

    /// <summary>
    ///     Conversion to serialize a value
    /// </summary>
    /// <param name="val">The value</param>
    /// <returns>The value</returns>
    public override V DeserializeValue(V val)
    {
        return val;
    }
}

/// <summary>
///     Dictionary that can serialize keys and values as other types
/// </summary>
/// <typeparam name="K">The key type</typeparam>
/// <typeparam name="V">The value type</typeparam>
/// <typeparam name="SK">The type which the key will be serialized for</typeparam>
/// <typeparam name="SV">The type which the value will be serialized for</typeparam>
[Serializable]
public abstract class SerializedDict<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver
{
    [SerializeField] private List<SK> m_Keys = new();

    [SerializeField] private List<SV> m_Values = new();

    /// <summary>
    ///     OnBeforeSerialize implementation.
    /// </summary>
    public void OnBeforeSerialize()
    {
        m_Keys.Clear();
        m_Values.Clear();

        foreach (var kvp in this)
        {
            m_Keys.Add(SerializeKey(kvp.Key));
            m_Values.Add(SerializeValue(kvp.Value));
        }
    }

    /// <summary>
    ///     OnAfterDeserialize implementation.
    /// </summary>
    public void OnAfterDeserialize()
    {
        for (var i = 0; i < m_Keys.Count; i++)
            if (m_Keys[i] != null)
            {
                var deserializedKey = DeserializeKey(m_Keys[i]);

                if (!ContainsKey(deserializedKey))
                    Add(DeserializeKey(m_Keys[i]), DeserializeValue(m_Values[i]));
            }

        m_Keys.Clear();
        m_Values.Clear();
    }

    /// <summary>
    ///     From <see cref="K" /> to <see cref="SK" />
    /// </summary>
    /// <param name="key">They key in <see cref="K" /></param>
    /// <returns>The key in <see cref="SK" /></returns>
    public abstract SK SerializeKey(K key);

    /// <summary>
    ///     From <see cref="V" /> to <see cref="SV" />
    /// </summary>
    /// <param name="value">The value in <see cref="V" /></param>
    /// <returns>The value in <see cref="SV" /></returns>
    public abstract SV SerializeValue(V value);


    /// <summary>
    ///     From <see cref="SK" /> to <see cref="K" />
    /// </summary>
    /// <param name="serializedKey">They key in <see cref="SK" /></param>
    /// <returns>The key in <see cref="K" /></returns>
    public abstract K DeserializeKey(SK serializedKey);

    /// <summary>
    ///     From <see cref="SV" /> to <see cref="V" />
    /// </summary>
    /// <param name="serializedValue">The value in <see cref="SV" /></param>
    /// <returns>The value in <see cref="V" /></returns>
    public abstract V DeserializeValue(SV serializedValue);
}
