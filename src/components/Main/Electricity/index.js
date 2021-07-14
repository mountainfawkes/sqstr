export default () => {
  function formSubmission(event) {
    event.preventDefault()
    return {
      type: event.target.electricity.value,
      electricity_unit: event.target.unit.value,
      electricity_value: event.target.electricity_value.value,
      country: event.target.country.value,
      state: event.target.state.value,
    }
  }

  return (
    <div>
      <h3>This is the electricity form</h3>
      <form onSubmit={formSubmission}>
        <input type='hidden' name='electricity' value='electricity' />
        <input type='hidden' name='unit' value='mwh' />
        <label htmlFor='electricity_value'>Electricity usage (in MWh):
          <input name='electricity_value' type='number' />
        </label>
        <label htmlFor='country'>Country:
          <select name='country'>
            <option value='us'>United States</option>
          </select>
        </label>
        <label htmlFor='state'>State:
          <select name='state'>
            <option value='or'>Oregon</option>
          </select>
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </div>
  )
}
