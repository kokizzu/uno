#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Uno.Extensions.Specialized;
using Windows.Foundation.Collections;

namespace Windows.Storage;

/// <summary>
/// Represents related app settings that must be serialized and deserialized atomically.
/// </summary>
public partial class ApplicationDataCompositeValue :
	IDictionary<string, object>,
	IEnumerable<KeyValuePair<string, object>>,
	IObservableMap<string, object>,
	IPropertySet
{
	private readonly Dictionary<string, object> _dictionary = new();

	/// <summary>
	/// Creates and initializes a new, initially empty, instance of the object.
	/// </summary>
	public ApplicationDataCompositeValue()
	{
	}

	/// <summary>
	/// Creates and initializes a new instance of the with the specified dictionary.
	/// </summary>
	/// <param name="dictionary">Dictionary.</param>
	/// <exception cref="ArgumentNullException">Thrown if parameter is null.</exception>
	internal ApplicationDataCompositeValue(Dictionary<string, object> dictionary)
	{
		if (dictionary is null)
		{
			throw new ArgumentNullException(nameof(dictionary));
		}

		_dictionary = dictionary.Where(i => i.Value is not null).ToDictionary();
	}

	/// <summary>
	/// Occurs when the observable map has changed.
	/// </summary>
	public event MapChangedEventHandler<string, object>? MapChanged;

	/// <summary>
	/// Gets the number of items contained in the property set.
	/// </summary>
	public uint Size => (uint)_dictionary.Count;

	/// <summary>
	/// Gets teh number of items contained in the property set.
	/// </summary>
	public int Count => _dictionary.Count;

	/// <summary>
	/// Gets a value indicating whether the collection is read-only.
	/// </summary>
	public bool IsReadOnly => false;

	/// <summary>
	/// Adds an item to the property set.
	/// </summary>
	/// <param name="key">The key to insert.</param>
	/// <param name="value">The value to insert.</param>
	public void Add(string key, object value)
	{
		if (value is null)
		{
			return;
		}

		_dictionary.Add(key, value);
		MapChanged?.Invoke(this, new MapChangedEventArgs(CollectionChange.ItemInserted, key));
	}

	/// <summary>
	/// Indicates whether the property set has an item with the specified key.
	/// </summary>
	/// <param name="key">Key.</param>
	/// <returns>True if found.</returns>
	public bool ContainsKey(string key) => _dictionary.ContainsKey(key);

	/// <summary>
	/// Removes a key from the property set.
	/// </summary>
	/// <param name="key">The key to remove.</param>
	/// <returns>True if the key was found.</returns>
	public bool Remove(string key)
	{
		var result = _dictionary.Remove(key);
		if (result)
		{
			MapChanged?.Invoke(this, new MapChangedEventArgs(CollectionChange.ItemRemoved, key));
		}

		return result;
	}

	/// <summary>
	/// Tries to get the value for the specified key.
	/// </summary>
	/// <param name="key">The key to retrieve.</param>
	/// <param name="value">The value correspodning with the key.</param>
	/// <returns>True if found.</returns>
	public bool TryGetValue(string key, [MaybeNullWhen(false)] out object value)
	{
		if (key is null)
		{
			throw new ArgumentNullException(nameof(key));
		}

		return _dictionary.TryGetValue(key, out value);
	}

	/// <summary>
	/// Gets or sets a value for the specified key.
	/// </summary>
	/// <param name="key">The key.</param>
	/// <returns>Value.</returns>
	public object this[string key]
	{
		get => _dictionary[key];
		set
		{
			if (value is null)
			{
				Remove(key);
				return;
			}

			// Add or update and raise map changed accordingly			
			if (_dictionary.TryGetValue(key, out var existingValue))
			{
				if (!Equals(value, existingValue))
				{
					_dictionary[key] = value;
					MapChanged?.Invoke(this, new MapChangedEventArgs(CollectionChange.ItemChanged, key));
				}
			}
			else
			{
				Add(key, value);
			}
		}
	}

	/// <summary>
	/// Returns all keys in the property set.
	/// </summary>
	public ICollection<string> Keys => _dictionary.Keys;

	/// <summary>
	/// Returns all values in the property set.
	/// </summary>
	public ICollection<object> Values => _dictionary.Values;

	/// <summary>
	/// Adds an item to the property set.
	/// </summary>
	/// <param name="item">Item to be added.</param>
	public void Add(KeyValuePair<string, object> item) => Add(item.Key, item.Value);

	/// <summary>
	/// Clears the property set.
	/// </summary>
	public void Clear()
	{
		_dictionary.Clear();
		MapChanged?.Invoke(this, new MapChangedEventArgs(CollectionChange.Reset, null));
	}

	/// <summary>
	/// Checks if the property set contains the specified item.
	/// </summary>
	/// <param name="item">Item to check.</param>
	/// <returns>True if found.</returns>
	public bool Contains(KeyValuePair<string, object> item) =>
		TryGetValue(item.Key, out var val) && Equals(item.Value, val);

	/// <summary>
	/// Copies the property set to an array.
	/// </summary>
	/// <param name="array">Array to copy to.</param>
	/// <param name="arrayIndex">Index of the start of the copy.</param>
	public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException(nameof(array));
		}

		if (arrayIndex < 0 || arrayIndex >= array.Length)
		{
			throw new ArgumentOutOfRangeException(nameof(arrayIndex), "The specified index is out of bounds of the specified array.");
		}

		// Check now, before starting to copy elements
		if (array.Length - arrayIndex < Count)
		{
			throw new ArgumentException(nameof(array), "The specified space is not sufficient to copy the elements from this Collection.");
		}

		foreach (var item in _dictionary)
		{
			array[arrayIndex++] = item;
		}
	}

	/// <summary>
	/// Removes an item from the property set.
	/// </summary>
	/// <param name="item">Item to remove.</param>
	/// <returns>True if found.</returns>
	public bool Remove(KeyValuePair<string, object> item) => Contains(item) && Remove(item.Key);

	/// <summary>
	/// Returns an enumerator for the property set.
	/// </summary>
	/// <returns>Enumerator.</returns>
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _dictionary.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
